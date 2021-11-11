using MachineLearning.ML.Utils.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Utils.ErrorFunction
{
    interface IErrorFunction : ICloneable
    {
        void Calculate(IActivationFunction af, int start, double[] neurons, double[] target, double[] error);

    }
}
