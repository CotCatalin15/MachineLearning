using MachineLearningLib.ML.Neural.Networks;
using MachineLearningLib.ML.Neural.Networks.Propagation;
using MachineLearningLib.ML.Neural.Networks.Propagation.ForwardNetwork;
using MachineLearningLib.ML.Utils.ActivationFunctions;
using MachineLearningLib.ML.Utils.Array;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Json.Net;
using MachineLearningLib.ML.Data.BasicData;
using MachineLearningLib.ML.Neural.Networks.Training.Propagation;
using MachineLearningLib.ML.Neural.Networks.Training.Propagation.Backpropagation;
using MachineLearningLib.ML.Neural.Networks.Training.Propagation.Resilient;

namespace ImageProcessing.Forms
{
    public partial class MainForm : Form
    {
        const string ModelExtensionFilter = "neural model files(*.model)|*.model";
        const string DigitExtensionFilter = "custome digits file(*.digit)|*.digit";

        ProgressBar[] _progressBars;
        Label[] _imageLabels;

        IPropagationNetwork _network;

        List<BasicDataPair> _customeDigits;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _network = new ParallelForwardNetwork(new BasicLayer[] { 
                new BasicLayer(28 * 28, new NullActivationFunction()),
                new BasicLayer(128, new SigmodFunction()),
                new BasicLayer(10, new SoftmaxActivation())
            });

            _customeDigits = new List<BasicDataPair>();
            UpdateCountLabel();

            #region EASY_LIST
            _progressBars = new ProgressBar[] { 
                progressBar0, progressBar1, progressBar2,
                progressBar3, progressBar4, progressBar5, 
                progressBar6, progressBar7, progressBar8, 
                progressBar9
            };

            _imageLabels = new Label[] {
                imageLabel0, imageLabel1, imageLabel2,
                imageLabel3, imageLabel4, imageLabel5,
                imageLabel6, imageLabel7, imageLabel8,
                imageLabel9
            };

            #endregion

            foreach (var label in _imageLabels)
                label.Text = "0%";

            openFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.InitialDirectory = Application.StartupPath;
            algorithCheckBox.SetItemChecked(1, true);
            algorithCheckBox.SelectedIndex = 1;
        }

        private void propagateButton_Click(object sender, EventArgs e)
        {
            //Create a 28 * 28 bitmap from the orignal
            Bitmap newImage = new Bitmap(drawablePictureBox.Framebuffer, new Size(28, 28));

            //Prepare data
            double[] input = new double[28 * 28];

            for (int i = 0; i < 28; ++i)
                for (int j = 0; j < 28; ++j)
                    input[i * 28 + j] = newImage.GetPixel(i, j).GetBrightness() > 0 ? (1.0) : (0.0);


            //Propagate 
            double[] output = new double[10];
            _network.Forward(input, output);

            UpdateProgressBar(output);


            //Clear the drawing
            drawablePictureBox.ClearCanvas();
        }


        void UpdateProgressBar(double[] outputs)
        {
            var (index, value) = ArrayEngine.GreatestValue(outputs);

            outputText.Text = index.ToString();

            //Convert output to [0, 1] range
            //var fnc = new SoftmaxActivation();
            //fnc.Activate(outputs, 0, 10);


            for (int i = 0; i < outputs.Length; ++i)

            {
                _progressBars[i].Value = (int)(outputs[i] * 100.0d);
                _imageLabels[i].Text = $"{(outputs[i] * 100):00}%";
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = ModelExtensionFilter;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream Stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {

                        var formatter = new BinaryFormatter();

                        _network = (ParallelForwardNetwork)formatter.Deserialize(Stream);

                        Stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o eroare la incarcarea modelului!");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = ModelExtensionFilter;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream Stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {

                        var formatter = new BinaryFormatter();

                        formatter.Serialize(Stream, _network);

                        Stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o eroare la salvarea modelului!");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _network = new ParallelForwardNetwork(new BasicLayer[] {
                new BasicLayer(28 * 28, new NullActivationFunction()),
                new BasicLayer(128, new SigmodFunction()),
                new BasicLayer(10, new SoftmaxActivation())
            });
        }

        private void algorithCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < algorithCheckBox.Items.Count; ++i)
                if (i != e.Index) algorithCheckBox.SetItemChecked(i, false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addCustomeButton_Click(object sender, EventArgs e)
        {
            //Create a 28 * 28 bitmap from the orignal
            Bitmap newImage = new Bitmap(trainDrawablePictureBox.Framebuffer, new Size(28, 28));

            //Prepare data
            double[] input = new double[28 * 28];

            for (int i = 0; i < 28; ++i)
                for (int j = 0; j < 28; ++j)
                    input[i * 28 + j] = newImage.GetPixel(i, j).GetBrightness() > 0 ? (1.0) : (0.0);

            double[] output = new double[10];

            int label = (int)digitNumeric.Value;
            output[label] = 1.0;

            _customeDigits.Add(new BasicDataPair(input, output));
            trainDrawablePictureBox.ClearCanvas();
            UpdateCountLabel();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            if(algorithCheckBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati un algoritm de antrenare!");
                return;
            }

            if (_customeDigits.Count == 0)
            {
                MessageBox.Show("Adaugati cel putin 1 cifra!");
                return;
            }

            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }

            trainProgressBar.Visible = true;
            trainProgressBar.Value = 0;
            trainProgressBar.Maximum = (int)epochNumeric.Value;


            int batchSize = (int)batchNumeric.Value;
            int numEpochs = (int)epochNumeric.Value;
            int selectedIndex = (int)algorithCheckBox.SelectedIndex;

            trainingWorker.RunWorkerAsync((batchSize, numEpochs, selectedIndex));
        }

        private void saveDigitsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = DigitExtensionFilter;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream Stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {

                        var formatter = new BinaryFormatter();

                        formatter.Serialize(Stream, _customeDigits);

                        Stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o eroare la salvarea cifrelor!");
                }
            }

            UpdateCountLabel();
        }

        private void loadDigitsButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = DigitExtensionFilter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream Stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {

                        var formatter = new BinaryFormatter();

                        _customeDigits = (List<BasicDataPair>)formatter.Deserialize(Stream);
                        
                        Stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o eroare la incarcarea modelului!");
                }
            }

            UpdateCountLabel();
        }

        void UpdateCountLabel()
        {
            countLabel.Text = $"{_customeDigits.Count}/{_customeDigits.Count}";
            batchNumeric.Maximum = _customeDigits.Count;
        }

        private void resetDigitButton_Click(object sender, EventArgs e)
        {
            _customeDigits.Clear();
            UpdateCountLabel();
        }

        private void trainingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BasicDataPair[] pairs = _customeDigits.ToArray();
            ArrayEngine.Shuffle(new Random(DateTime.Now.Millisecond), pairs);
            BasicDataSet data = new BasicDataSet(pairs);

            var (batchSize, numEpochs, selectedIndex) = ((int, int, int))e.Argument;

            Propagator algorithm;   
            switch(selectedIndex)
            {
                case 0:
                    algorithm = new BackPropagation((ForwardPropagationNetwork)_network, data, batchSize);
                    break;
                case 1:
                    algorithm = new ResilientPropagation((ForwardPropagationNetwork)_network, data, batchSize);
                    break;
                default:
                    algorithm = new BackPropagation((ForwardPropagationNetwork)_network, data, batchSize);
                    break;
            }

            

            for(int i = 0; i < numEpochs; ++i)
            {
                algorithm.Iterate();
                ArrayEngine.Shuffle(new Random(DateTime.Now.Millisecond), pairs);
                algorithm.Data = new BasicDataSet(pairs);

                Console.WriteLine(algorithm.Error);
                trainingWorker.ReportProgress(i + 1);
            }

            trainingWorker.ReportProgress(0);
        }

        private void trainingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == 0)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = true;
                }
                trainProgressBar.Visible = false;
            }
            else
            {
                ++trainProgressBar.Value;
            }
        }
    }
}
