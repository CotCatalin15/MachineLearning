using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Utils.ActivationFunctions
{
    public class NullActivationFunction : IActivationFunction
    {
        public string FullTypeName => typeof(NullActivationFunction).FullName;

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
