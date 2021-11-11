using MachineLearningLib.ML.Utils.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Utils.ErrorFunction
{
    public interface IErrorFunction : ICloneable
    {
        void Calculate(IActivationFunction af, int start, double[] neurons, double[] target, double[] error);

    }
}
