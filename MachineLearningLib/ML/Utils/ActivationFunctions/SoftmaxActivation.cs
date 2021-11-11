using MachineLearningLib.ML.Utils.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningLib.ML.Utils.ActivationFunctions
{
    public class SoftmaxActivation : IActivationFunction
    {
        public string FullTypeName => typeof(SoftmaxActivation).FullName;
        public void Activate(double[] neurons, int start, int size)
        {
            double sum = 0;
            for (int i = start; i < start + size; i++)
            {
                neurons[i] = Math.Exp(neurons[i]);
                sum += neurons[i];
            }
            for (int i = start; i < start + size; i++)
            {
                neurons[i] = neurons[i] / sum;
            }
        }

        public double Derivate(double a)
        {
            return 1.0d;
        }

        public object Clone()
        {
            return new SoftmaxActivation();
        }
    }
}
