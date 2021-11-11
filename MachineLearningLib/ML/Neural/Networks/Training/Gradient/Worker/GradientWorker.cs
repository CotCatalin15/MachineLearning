using MachineLearningLib.ML.Data;
using MachineLearningLib.ML.Neural.Networks.Propagation;
using MachineLearningLib.ML.Neural.Networks.Propagation.ForwardNetwork;
using MachineLearningLib.ML.Neural.Networks.Training.Propagation;
using MachineLearningLib.ML.Utils.ActivationFunctions;
using MachineLearningLib.ML.Utils.Array;
using MachineLearningLib.ML.Utils.ErrorCalculation;
using MachineLearningLib.ML.Utils.ErrorFunction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningLib.ML.Neural.Networks.Training.Gradient.Worker
{
    //Processes prepared data
    class GradientWorker
    {
        /// <summary>
        /// The owner of the worker
        /// </summary>
        Propagator _propagator;

        /// <summary>
        /// The network's proxy
        /// </summary>
        PropagationNetworkProxy _network;


        /// <summary>
        /// Error function to calculate the output error value
        /// </summary>
        IErrorFunction _errorFunction;

        /// <summary>
        /// Training set
        /// </summary>
        IMLDataSet _trainingSet;


        ErrorCalculation _errorCalculation;

        int _low;

        int _high;


        /// <summary>
        /// Output neuron's value
        /// </summary>
        double[] _outputValue;


        /// <summary>
        /// Each neuron's delta
        /// </summary>
        double[] _layerDelta;

        /// <summary>
        /// Gradients for all weights
        /// </summary>
        double[] _gradients;



        int _error;


        public GradientWorker(PropagationNetworkProxy proxy, Propagator propagator)
        {
            _propagator = propagator;
            _network = proxy;
            _errorFunction = (IErrorFunction)propagator.ErrorFunction.Clone();
            _layerDelta = new double[proxy.NumNeurons];
            _gradients = new double[proxy.NumWeights];
            _outputValue = new double[proxy.LayerCount[_network.LayerCount.Length - 1]];

            _errorCalculation = new ErrorCalculation();
        }

        public void Train(IMLDataSet data, int low, int high)
        {
            _trainingSet = data;
            _low = low;
            _high = high;


            _errorCalculation.Reset();

            for (int i = _low; i < _high; ++i)
            {
                Process(_trainingSet[i]);
            }


            double error = _errorCalculation.Calculate();
            _propagator.ReportProgress(_gradients, error);
            ArrayEngine.SetValue(_gradients, 0);
        }

        void Process(IMLDataPair pair)
        {
            var (values, target) = (pair.Values, pair.Target);

            //compute the values

            _network.Forward(values, _outputValue);

            ComputeGradients(target);
        }


        public void ComputeGradients(double[] target)
        {
            _errorCalculation.UpdateError(_outputValue, target, 1.0);

            //output layer activation function
            _errorFunction.Calculate(_network.ActivationFunction[_network.ActivationFunction.Length - 1],  
                _network.LayerOffset[_network.LayerOffset.Length - 1],
                _network.Neurons, target, _layerDelta);


            for (int i = _network.NumLayers - 2; i >= 0; --i)
                ProcessLayer(i);
        }

        void ProcessLayer(int layer)
        {
            IActivationFunction activationFunction = _network.ActivationFunction[layer];

            //Ignore the bias
            int numNextLayerNeurons = _network.LayerCount[layer + 1];
            int numCurrentLayerNeurons = _network.LayerFeedCount[layer];

            int nCurrentLow = _network.LayerOffset[layer];
            int nCurrentHigh = nCurrentLow + numCurrentLayerNeurons;

            int nNextLow = _network.LayerOffset[layer + 1];
            int nNextHigh = nNextLow + numNextLayerNeurons;

            int currentLayerSize = _network.LayerFeedCount[layer];
            
            int y = 0;
            for(int i = nCurrentLow; i < nCurrentHigh; ++i)
            {
                double output = _network.Neurons[i];

                int weightIndex = _network.WeightOffset[nNextLow] + y;
                double sum = 0;

                for(int j = nNextLow; j < nNextHigh; ++j)
                {
                    sum += _layerDelta[j] * _network.Weights[weightIndex];

                    //Add gradients over the iterations
                    _gradients[weightIndex] += output * _layerDelta[j];

                    weightIndex += currentLayerSize;
                }

                _layerDelta[i] = sum * activationFunction.Derivate(_network.Neurons[i]);
                ++y;
            }



        }

    }
}
