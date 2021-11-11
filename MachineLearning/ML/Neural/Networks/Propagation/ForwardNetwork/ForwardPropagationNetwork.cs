using MachineLearning.ML.Utils.ActivationFunctions;
using MachineLearning.ML.Utils.Array;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork
{
    [Serializable]
    class ForwardPropagationNetwork : IPropagationNetwork
    {

        /// <summary>
        /// Number of neurons per layer(without the bias)
        /// </summary>
        protected int[] _layerCount;

        /// <summary>
        /// Number of neurons that feed the next layer including the bias
        /// </summary>
        protected int[] _layerFeedCount;

        /// <summary>
        /// All network's weights
        /// </summary>
        protected double[] _weights;


        /// <summary>
        /// All network's neurons
        /// </summary>
        protected double[] _neuronValues;


        /// <summary>
        /// Each layer activation function
        /// </summary>
        [NonSerialized] protected IActivationFunction[] _activationFunction;

        /// <summary>
        /// Where each neurons weight starts
        /// </summary>
        protected int[]  _weightsOffset;


        /// <summary>
        /// Where each neuron starts
        /// </summary>
        protected int[] _layerOffset;

        //Empty constructor for cloning
        protected ForwardPropagationNetwork()
        {

        }

        public ForwardPropagationNetwork(BasicLayer[] layers)
        {
            if (layers.Length < 2)
                throw new Exception("Minimum is 2 layers!");

            int numLayers = layers.Length;

            _layerCount = new int[numLayers];
            _layerFeedCount = new int[numLayers];
            _layerOffset = new int[numLayers];

            _activationFunction = new IActivationFunction[numLayers];

            int numNeurons = 0;
            int numWeights = 0;
            
            for (int i = 0; i < layers.Length; ++i)
            {
                _layerCount[i] = layers[i].LayerNeurons;
                _layerFeedCount[i] = layers[i].TotalNeurons;


                if (i == 0 && layers[i].ActivationFunction == null)
                    _activationFunction[i] = new NullActivationFunction();

                numNeurons += layers[i].TotalNeurons;

                if (i > 0)
                {
                    if (layers[i].ActivationFunction != null)
                        _activationFunction[i] = layers[i].ActivationFunction;
                    else
                        throw new Exception("Each layer must have an activation function");


                    numWeights += layers[i - 1].TotalNeurons * layers[i].LayerNeurons;
                    _layerOffset[i] = _layerOffset[i - 1] + _layerFeedCount[i - 1];
                }
            }

            _weightsOffset  = new int[numNeurons];
            _neuronValues   = new double[numNeurons];
            _weights        = new double[numWeights];

            int weightIndexOffset = 0;
            int weightIndex = _layerFeedCount[0];

            int biasIndex = 0;
            for(int i = 0; i < NumLayers; ++i)
            {
                if(i > 0)
                {
                    for (int j = 0; j < _layerCount[i]; ++j)
                    {
                        _weightsOffset[weightIndex++] = weightIndexOffset;
                        weightIndexOffset += _layerFeedCount[i - 1];
                    }
                    if (layers[i].HasBias == true)
                        ++weightIndex;
                }

                if (layers[i].HasBias)
                {
                    biasIndex += _layerFeedCount[i];
                    _neuronValues[biasIndex - 1] = layers[i].BiasActivationValue;
                }

            }

            Randomize();
        }


        void Randomize(int? seed = null, double low = -1.0d, double high = 1.0d)
        {
            Random random = new Random(seed.HasValue ? (seed.Value) : (DateTime.Now.Millisecond));

            for (int i = 0; i < _weights.Length; ++i)
                _weights[i] = random.NextDouble() * (high - low) + low;

        }

        /// <summary>
        /// Propagates forward the network
        /// </summary>
        /// <param name="inputs"> Return the output layer </param>
        /// <returns></returns>
        public virtual void Forward(double[] inputs, double[] outputs)
        {
            if (inputs.Length != _layerCount[0])
                throw new Exception("Different numbers of inputs");

            ArrayEngine.Copy(_neuronValues, 0, inputs, 0, inputs.Length);

            ComputeOutput();

            if (outputs.Length != NumOutputNeurons)
                throw new Exception("Outputs array has different size!");

            if(outputs != null)
            {
                int outputOffset = _layerOffset[_layerOffset.Length - 1];
                ArrayEngine.Copy(outputs, 0, _neuronValues, outputOffset, NumOutputNeurons);
            }
        }

        void ComputeOutput()
        {
            for (int i = 1; i < NumLayers; ++i)
            {
                ComputeLayer(i);
            }
        }


        void ComputeLayer(int layer)
        {
            int nHigh = _layerOffset[layer] + _layerCount[layer];
            for(int i = _layerOffset[layer]; i < nHigh; ++i)
            {
                int wHigh = _weightsOffset[i] + _layerFeedCount[layer - 1];

                _neuronValues[i] = 0;
                for(int weightIndex = _weightsOffset[i], neuronIndex = _layerOffset[layer - 1]; 
                    weightIndex < wHigh; 
                    ++weightIndex, ++neuronIndex)
                {
                    _neuronValues[i] += _weights[weightIndex] * _neuronValues[neuronIndex];
                }

            }

            _activationFunction[layer].Activate(_neuronValues, _layerOffset[layer], _layerCount[layer]);
        }

        public PropagationNetworkProxy CreateProxy()
        {
            PropagationNetworkProxy newNetwork = new PropagationNetworkProxy(this);

            return newNetwork;
        }

        public int NumLayers { get => _layerCount.Length; }
        public int NumNeurons { get => _neuronValues.Length; }
        public int NumWeights { get => _weights.Length; }
        public int[] LayerCount { get => _layerCount; }
        public int[] LayerFeedCount { get => _layerFeedCount; }
        public double[] Weights { get => _weights; }
        public double[] Neurons { get => _neuronValues; }
        public IActivationFunction[] ActivationFunction { get => _activationFunction; }
        public int[] WeightOffset { get => _weightsOffset; }
        public int[] LayerOffset { get => _layerOffset; }
        public int NumOutputNeurons { get => _layerCount[_layerCount.Length - 1]; }
        public ForwardPropagationNetwork Network { get => this; }
    }

}
