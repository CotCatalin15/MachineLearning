using MachineLearning.ML.Utils.Array;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork
{
    class ParallelForwardNetwork : ForwardPropagationNetwork
    {
        public ParallelForwardNetwork(BasicLayer[] layers) :
            base(layers)
        { }

        public override void Forward(double[] inputs, double[] outputs)
        {
            if (inputs.Length != _layerCount[0])
                throw new Exception("Different numbers of inputs");

            ArrayEngine.Copy(_neuronValues, 0, inputs, 0, inputs.Length);

            ComputeOutput();

            if (outputs.Length != NumOutputNeurons)
                throw new Exception("Outputs array has different size!");

            if (outputs != null)
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

            Parallel.For(_layerOffset[layer], nHigh, (i)=> {

                int wHigh = _weightsOffset[i] + _layerFeedCount[layer - 1];

                _neuronValues[i] = 0;
                for (int weightIndex = _weightsOffset[i], neuronIndex = _layerOffset[layer - 1];
                    weightIndex < wHigh;
                    ++weightIndex, ++neuronIndex)
                {
                    _neuronValues[i] += _weights[weightIndex] * _neuronValues[neuronIndex];
                }
                

            });

            _activationFunction[layer].Activate(_neuronValues, _layerOffset[layer], _layerCount[layer]);
        }

    }
}
