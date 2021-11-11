
namespace ImageProcessing.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.trainPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.algorithCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.epochNumeric = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.batchNumeric = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.digitNumeric = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.addCustomeButton = new System.Windows.Forms.Button();
            this.trainDrawablePictureBox = new ImageProcessing.CustomeControlls.DrawablePictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetDigitButton = new System.Windows.Forms.Button();
            this.trainProgressBar = new CircularProgressBar.CircularProgressBar();
            this.saveDigitsButton = new System.Windows.Forms.Button();
            this.trainButton = new System.Windows.Forms.Button();
            this.loadDigitsButton = new System.Windows.Forms.Button();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.propagateButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.drawablePictureBox = new ImageProcessing.CustomeControlls.DrawablePictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.imageLabel9 = new System.Windows.Forms.Label();
            this.imageLabel8 = new System.Windows.Forms.Label();
            this.imageLabel7 = new System.Windows.Forms.Label();
            this.imageLabel6 = new System.Windows.Forms.Label();
            this.imageLabel5 = new System.Windows.Forms.Label();
            this.imageLabel4 = new System.Windows.Forms.Label();
            this.imageLabel3 = new System.Windows.Forms.Label();
            this.imageLabel2 = new System.Windows.Forms.Label();
            this.imageLabel1 = new System.Windows.Forms.Label();
            this.imageLabel0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar0 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.trainingWorker = new System.ComponentModel.BackgroundWorker();
            this.trainPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epochNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // trainPage
            // 
            this.trainPage.Controls.Add(this.tableLayoutPanel5);
            this.trainPage.Location = new System.Drawing.Point(4, 29);
            this.trainPage.Name = "trainPage";
            this.trainPage.Padding = new System.Windows.Forms.Padding(3);
            this.trainPage.Size = new System.Drawing.Size(1262, 750);
            this.trainPage.TabIndex = 1;
            this.trainPage.Text = "Train";
            this.trainPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1256, 744);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.70418F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.29582F));
            this.tableLayoutPanel6.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.93225F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.06775F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(622, 366);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.algorithCheckBox);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(137, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 269);
            this.panel1.TabIndex = 0;
            // 
            // algorithCheckBox
            // 
            this.algorithCheckBox.CheckOnClick = true;
            this.algorithCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithCheckBox.FormattingEnabled = true;
            this.algorithCheckBox.Items.AddRange(new object[] {
            "BackProp",
            "RPROP"});
            this.algorithCheckBox.Location = new System.Drawing.Point(0, 29);
            this.algorithCheckBox.Name = "algorithCheckBox";
            this.algorithCheckBox.Size = new System.Drawing.Size(129, 100);
            this.algorithCheckBox.TabIndex = 3;
            this.algorithCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.algorithCheckBox_ItemCheck);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 26);
            this.label16.TabIndex = 1;
            this.label16.Text = "Algoritm";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.epochNumeric);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.batchNumeric);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setari";
            // 
            // epochNumeric
            // 
            this.epochNumeric.Location = new System.Drawing.Point(184, 172);
            this.epochNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.epochNumeric.Name = "epochNumeric";
            this.epochNumeric.Size = new System.Drawing.Size(120, 29);
            this.epochNumeric.TabIndex = 3;
            this.epochNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Numar iteratii";
            // 
            // batchNumeric
            // 
            this.batchNumeric.Location = new System.Drawing.Point(184, 99);
            this.batchNumeric.Name = "batchNumeric";
            this.batchNumeric.Size = new System.Drawing.Size(120, 29);
            this.batchNumeric.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Dimensiune lot";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.countLabel);
            this.groupBox1.Controls.Add(this.digitNumeric);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.addCustomeButton);
            this.groupBox1.Controls.Add(this.trainDrawablePictureBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(631, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cifre proprii";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(180, 321);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(60, 20);
            this.countLabel.TabIndex = 7;
            this.countLabel.Text = "label18";
            // 
            // digitNumeric
            // 
            this.digitNumeric.Location = new System.Drawing.Point(398, 171);
            this.digitNumeric.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digitNumeric.Name = "digitNumeric";
            this.digitNumeric.Size = new System.Drawing.Size(120, 26);
            this.digitNumeric.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(394, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Cifra desenata";
            // 
            // addCustomeButton
            // 
            this.addCustomeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCustomeButton.Location = new System.Drawing.Point(398, 244);
            this.addCustomeButton.Name = "addCustomeButton";
            this.addCustomeButton.Size = new System.Drawing.Size(143, 66);
            this.addCustomeButton.TabIndex = 3;
            this.addCustomeButton.Text = "Adauga cifra";
            this.addCustomeButton.UseVisualStyleBackColor = true;
            this.addCustomeButton.Click += new System.EventHandler(this.addCustomeButton_Click);
            // 
            // trainDrawablePictureBox
            // 
            this.trainDrawablePictureBox.BrushColor = System.Drawing.Color.White;
            this.trainDrawablePictureBox.ClearColor = System.Drawing.Color.Black;
            this.trainDrawablePictureBox.Location = new System.Drawing.Point(77, 56);
            this.trainDrawablePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trainDrawablePictureBox.Name = "trainDrawablePictureBox";
            this.trainDrawablePictureBox.Size = new System.Drawing.Size(250, 250);
            this.trainDrawablePictureBox.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Deseneaza cifra";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resetDigitButton);
            this.panel2.Controls.Add(this.trainProgressBar);
            this.panel2.Controls.Add(this.saveDigitsButton);
            this.panel2.Controls.Add(this.trainButton);
            this.panel2.Controls.Add(this.loadDigitsButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(631, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 366);
            this.panel2.TabIndex = 3;
            // 
            // resetDigitButton
            // 
            this.resetDigitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDigitButton.Location = new System.Drawing.Point(398, 31);
            this.resetDigitButton.Name = "resetDigitButton";
            this.resetDigitButton.Size = new System.Drawing.Size(180, 56);
            this.resetDigitButton.TabIndex = 4;
            this.resetDigitButton.Text = "Reseteaza";
            this.resetDigitButton.UseVisualStyleBackColor = true;
            this.resetDigitButton.Click += new System.EventHandler(this.resetDigitButton_Click);
            // 
            // trainProgressBar
            // 
            this.trainProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.trainProgressBar.AnimationSpeed = 500;
            this.trainProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.trainProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.trainProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trainProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trainProgressBar.InnerMargin = 2;
            this.trainProgressBar.InnerWidth = -1;
            this.trainProgressBar.Location = new System.Drawing.Point(41, 144);
            this.trainProgressBar.MarqueeAnimationSpeed = 2000;
            this.trainProgressBar.Name = "trainProgressBar";
            this.trainProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.trainProgressBar.OuterMargin = -25;
            this.trainProgressBar.OuterWidth = 26;
            this.trainProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trainProgressBar.ProgressWidth = 25;
            this.trainProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.trainProgressBar.Size = new System.Drawing.Size(180, 180);
            this.trainProgressBar.StartAngle = 270;
            this.trainProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.trainProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.trainProgressBar.SubscriptText = "";
            this.trainProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.trainProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.trainProgressBar.SuperscriptText = "";
            this.trainProgressBar.TabIndex = 3;
            this.trainProgressBar.Text = "Progres ";
            this.trainProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.trainProgressBar.Value = 68;
            this.trainProgressBar.Visible = false;
            // 
            // saveDigitsButton
            // 
            this.saveDigitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDigitsButton.Location = new System.Drawing.Point(398, 129);
            this.saveDigitsButton.Name = "saveDigitsButton";
            this.saveDigitsButton.Size = new System.Drawing.Size(180, 56);
            this.saveDigitsButton.TabIndex = 2;
            this.saveDigitsButton.Text = "Salveaza cifrele";
            this.saveDigitsButton.UseVisualStyleBackColor = true;
            this.saveDigitsButton.Click += new System.EventHandler(this.saveDigitsButton_Click);
            // 
            // trainButton
            // 
            this.trainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainButton.Location = new System.Drawing.Point(115, 48);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(180, 56);
            this.trainButton.TabIndex = 1;
            this.trainButton.Text = "Antreneaza";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // loadDigitsButton
            // 
            this.loadDigitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDigitsButton.Location = new System.Drawing.Point(398, 223);
            this.loadDigitsButton.Name = "loadDigitsButton";
            this.loadDigitsButton.Size = new System.Drawing.Size(180, 56);
            this.loadDigitsButton.TabIndex = 0;
            this.loadDigitsButton.Text = "Incarca cifrele";
            this.loadDigitsButton.UseVisualStyleBackColor = true;
            this.loadDigitsButton.Click += new System.EventHandler(this.loadDigitsButton_Click);
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.tableLayoutPanel1);
            this.mainPage.Location = new System.Drawing.Point(4, 29);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(1262, 750);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.62983F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.37017F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 744);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.36977F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.63023F));
            this.tableLayoutPanel2.Controls.Add(this.propagateButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.drawablePictureBox, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.27281F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.39386F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(622, 571);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // propagateButton
            // 
            this.propagateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propagateButton.Location = new System.Drawing.Point(222, 369);
            this.propagateButton.Name = "propagateButton";
            this.propagateButton.Size = new System.Drawing.Size(280, 74);
            this.propagateButton.TabIndex = 1;
            this.propagateButton.Text = "Analizeaza";
            this.propagateButton.UseVisualStyleBackColor = true;
            this.propagateButton.Click += new System.EventHandler(this.propagateButton_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(222, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(397, 31);
            this.label11.TabIndex = 2;
            this.label11.Text = "Deseneaza o cifra!";
            // 
            // drawablePictureBox
            // 
            this.drawablePictureBox.BrushColor = System.Drawing.Color.White;
            this.drawablePictureBox.ClearColor = System.Drawing.Color.Black;
            this.drawablePictureBox.Location = new System.Drawing.Point(223, 83);
            this.drawablePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawablePictureBox.Name = "drawablePictureBox";
            this.drawablePictureBox.Size = new System.Drawing.Size(250, 250);
            this.drawablePictureBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.6406F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.3594F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel3.Controls.Add(this.imageLabel9, 2, 9);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel8, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel7, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel6, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel5, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel4, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel3, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel0, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.progressBar0, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBar1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.progressBar2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.progressBar3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.progressBar4, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.progressBar5, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.progressBar6, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.progressBar7, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.progressBar8, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.progressBar9, 1, 9);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(631, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(622, 571);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // imageLabel9
            // 
            this.imageLabel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel9.AutoSize = true;
            this.imageLabel9.Location = new System.Drawing.Point(415, 530);
            this.imageLabel9.Name = "imageLabel9";
            this.imageLabel9.Size = new System.Drawing.Size(70, 24);
            this.imageLabel9.TabIndex = 30;
            this.imageLabel9.Text = "label22";
            // 
            // imageLabel8
            // 
            this.imageLabel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel8.AutoSize = true;
            this.imageLabel8.Location = new System.Drawing.Point(415, 472);
            this.imageLabel8.Name = "imageLabel8";
            this.imageLabel8.Size = new System.Drawing.Size(70, 24);
            this.imageLabel8.TabIndex = 29;
            this.imageLabel8.Text = "label21";
            // 
            // imageLabel7
            // 
            this.imageLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel7.AutoSize = true;
            this.imageLabel7.Location = new System.Drawing.Point(415, 415);
            this.imageLabel7.Name = "imageLabel7";
            this.imageLabel7.Size = new System.Drawing.Size(70, 24);
            this.imageLabel7.TabIndex = 28;
            this.imageLabel7.Text = "label20";
            // 
            // imageLabel6
            // 
            this.imageLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel6.AutoSize = true;
            this.imageLabel6.Location = new System.Drawing.Point(415, 358);
            this.imageLabel6.Name = "imageLabel6";
            this.imageLabel6.Size = new System.Drawing.Size(70, 24);
            this.imageLabel6.TabIndex = 27;
            this.imageLabel6.Text = "label19";
            // 
            // imageLabel5
            // 
            this.imageLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel5.AutoSize = true;
            this.imageLabel5.Location = new System.Drawing.Point(415, 301);
            this.imageLabel5.Name = "imageLabel5";
            this.imageLabel5.Size = new System.Drawing.Size(70, 24);
            this.imageLabel5.TabIndex = 26;
            this.imageLabel5.Text = "label18";
            // 
            // imageLabel4
            // 
            this.imageLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel4.AutoSize = true;
            this.imageLabel4.Location = new System.Drawing.Point(415, 244);
            this.imageLabel4.Name = "imageLabel4";
            this.imageLabel4.Size = new System.Drawing.Size(70, 24);
            this.imageLabel4.TabIndex = 25;
            this.imageLabel4.Text = "label17";
            // 
            // imageLabel3
            // 
            this.imageLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel3.AutoSize = true;
            this.imageLabel3.Location = new System.Drawing.Point(415, 187);
            this.imageLabel3.Name = "imageLabel3";
            this.imageLabel3.Size = new System.Drawing.Size(70, 24);
            this.imageLabel3.TabIndex = 24;
            this.imageLabel3.Text = "label16";
            // 
            // imageLabel2
            // 
            this.imageLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel2.AutoSize = true;
            this.imageLabel2.Location = new System.Drawing.Point(415, 130);
            this.imageLabel2.Name = "imageLabel2";
            this.imageLabel2.Size = new System.Drawing.Size(70, 24);
            this.imageLabel2.TabIndex = 23;
            this.imageLabel2.Text = "label15";
            // 
            // imageLabel1
            // 
            this.imageLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel1.AutoSize = true;
            this.imageLabel1.Location = new System.Drawing.Point(415, 73);
            this.imageLabel1.Name = "imageLabel1";
            this.imageLabel1.Size = new System.Drawing.Size(70, 24);
            this.imageLabel1.TabIndex = 22;
            this.imageLabel1.Text = "label14";
            // 
            // imageLabel0
            // 
            this.imageLabel0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabel0.AutoSize = true;
            this.imageLabel0.Location = new System.Drawing.Point(415, 16);
            this.imageLabel0.Name = "imageLabel0";
            this.imageLabel0.Size = new System.Drawing.Size(70, 24);
            this.imageLabel0.TabIndex = 21;
            this.imageLabel0.Text = "label13";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "6";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "7";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "8";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "9";
            // 
            // progressBar0
            // 
            this.progressBar0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar0.Location = new System.Drawing.Point(67, 17);
            this.progressBar0.Name = "progressBar0";
            this.progressBar0.Size = new System.Drawing.Size(342, 23);
            this.progressBar0.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(67, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(67, 131);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(342, 23);
            this.progressBar2.TabIndex = 12;
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.Location = new System.Drawing.Point(67, 188);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(342, 23);
            this.progressBar3.TabIndex = 13;
            // 
            // progressBar4
            // 
            this.progressBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar4.Location = new System.Drawing.Point(67, 245);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(342, 23);
            this.progressBar4.TabIndex = 14;
            // 
            // progressBar5
            // 
            this.progressBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar5.Location = new System.Drawing.Point(67, 302);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(342, 23);
            this.progressBar5.TabIndex = 15;
            // 
            // progressBar6
            // 
            this.progressBar6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar6.Location = new System.Drawing.Point(67, 359);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(342, 23);
            this.progressBar6.TabIndex = 16;
            // 
            // progressBar7
            // 
            this.progressBar7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar7.Location = new System.Drawing.Point(67, 416);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(342, 23);
            this.progressBar7.TabIndex = 17;
            // 
            // progressBar8
            // 
            this.progressBar8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar8.Location = new System.Drawing.Point(67, 473);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(342, 23);
            this.progressBar8.TabIndex = 18;
            // 
            // progressBar9
            // 
            this.progressBar9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar9.Location = new System.Drawing.Point(67, 530);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(342, 23);
            this.progressBar9.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel4.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.outputText, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.loadButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.saveButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.resetButton, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 580);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.90071F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.09929F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(622, 161);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(143, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Rezultat";
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.BackColor = System.Drawing.Color.White;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(241, 22);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(173, 32);
            this.outputText.TabIndex = 1;
            // 
            // loadButton
            // 
            this.loadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(3, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(116, 70);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Incarca model";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(3, 79);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 58);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Salveaza modelul";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(420, 79);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(199, 58);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reseteaza modelul";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.trainPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 783);
            this.tabControl1.TabIndex = 0;
            // 
            // trainingWorker
            // 
            this.trainingWorker.WorkerReportsProgress = true;
            this.trainingWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.trainingWorker_DoWork);
            this.trainingWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.trainingWorker_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 783);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trainPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epochNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage trainPage;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button propagateButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label imageLabel9;
        private System.Windows.Forms.Label imageLabel8;
        private System.Windows.Forms.Label imageLabel7;
        private System.Windows.Forms.Label imageLabel6;
        private System.Windows.Forms.Label imageLabel5;
        private System.Windows.Forms.Label imageLabel4;
        private System.Windows.Forms.Label imageLabel3;
        private System.Windows.Forms.Label imageLabel2;
        private System.Windows.Forms.Label imageLabel1;
        private System.Windows.Forms.Label imageLabel0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar0;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown epochNumeric;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown batchNumeric;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox algorithCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private CustomeControlls.DrawablePictureBox trainDrawablePictureBox;
        private CustomeControlls.DrawablePictureBox drawablePictureBox;
        private System.Windows.Forms.Button addCustomeButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown digitNumeric;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveDigitsButton;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button loadDigitsButton;
        private CircularProgressBar.CircularProgressBar trainProgressBar;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button resetDigitButton;
        private System.ComponentModel.BackgroundWorker trainingWorker;
    }
}