using MachineLearning.ML.Utils.ActivationFunctions;
using MachineLearning.ML.Utils.Array;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork
{
    internal class PropagationNetworkProxy : ForwardPropagationNetwork
    {
        public PropagationNetworkProxy(ForwardPropagationNetwork network) : 
            base()
        {
            //They do not change
            _layerCount         = network.LayerCount;
            _layerFeedCount     = network.LayerFeedCount;
            _weights            = network.Weights;
            _weightsOffset      = network.WeightOffset;
            _layerOffset        = network.LayerOffset;

            _activationFunction = new IActivationFunction[network.ActivationFunction.Length];
            for (int i = 0; i < ActivationFunction.Length; ++i)
                _activationFunction[i] = (IActivationFunction)network.ActivationFunction[i].Clone();

            _neuronValues = ArrayEngine.CloneArray(network.Neurons);
        }

    }
}
