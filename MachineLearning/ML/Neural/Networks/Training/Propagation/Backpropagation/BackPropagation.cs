using MachineLearning.ML.Data;
using MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork;
using MachineLearning.ML.Utils.ErrorFunction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Neural.Networks.Training.Propagation.Backpropagation
{
    class BackPropagation : Propagator
    {
        public BackPropagation(ForwardPropagationNetwork network, IMLDataSet DataSet, int BatchSize = 0, int numThreads = 0, IErrorFunction function = null) :
            base(network, DataSet, BatchSize, numThreads, function)
        {

        }

        public override double UpdateWeights(double[] gradients, double[] lastGradients, int index)
        {
            return gradients[index] * 0.03d;
        }
    }
}
