using MachineLearningLib.ML.Utils.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Utils.ErrorFunction
{
    public class LinearErrorFunction : IErrorFunction
    {
        public void Calculate(IActivationFunction af, int start, double[] neurons, double[] target, double[] error)
        {
            for(int i = 0; i < target.Length; ++i)
            {
                int nIndex = start + i;
                double derivative = af.Derivate(neurons[nIndex]);
                error[nIndex] = (target[i] - neurons[nIndex]) * derivative;
            }
        }

        public object Clone()
        {
            return new LinearErrorFunction();
        }
    }
}
