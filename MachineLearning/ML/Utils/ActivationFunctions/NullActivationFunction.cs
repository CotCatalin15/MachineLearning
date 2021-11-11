using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Utils.ActivationFunctions
{
    class NullActivationFunction : IActivationFunction
    {
        public void Activate(double[] neurons, int start, int size)
        {
            throw new Exception("Null activation function called");
        }

        public object Clone()
        {
            return new NullActivationFunction();
        }

        public double Derivate(double a)
        {
            return 0.0d;
        }
    }
}
