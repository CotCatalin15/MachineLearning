using MachineLearningLib.ML.Utils;
using MachineLearningLib.ML.Utils.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Neural.Networks
{
    public class BasicLayer : ICloneable
    {

        int _count;
        double _biasActivation;
        IActivationFunction _activationFunction;

        public BasicLayer(int NumNeurons, IActivationFunction Function, double biasActivation = 1.0d)
        {
            _count = NumNeurons;
            _biasActivation = biasActivation;
            _activationFunction = Function;
        }

        /// <summary>
        /// Returns number of neurons excluding the bias
        /// </summary>
        public int LayerNeurons { get => _count; }

        //Total number of neurons including the bias
        public int TotalNeurons { get => _count + (HasBias ? (1) : (0)); }

        public double BiasActivationValue { get => _biasActivation; }

        public bool HasBias { get => Math.Abs(_biasActivation) > MLUtils.ZeroTolerance; }

        public IActivationFunction ActivationFunction { get => _activationFunction; }
        public object Clone()
        {
            return new BasicLayer(_count, _activationFunction, _biasActivation);
        }
    }
}
