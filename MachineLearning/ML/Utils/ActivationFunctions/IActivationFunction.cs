using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Utils.ActivationFunctions
{
    interface IActivationFunction : ICloneable
    {
        void Activate(double[] neurons, int start, int size);

        double Derivate(double a);
    }
}
