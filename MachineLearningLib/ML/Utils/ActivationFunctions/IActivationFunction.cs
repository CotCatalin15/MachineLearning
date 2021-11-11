using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MachineLearningLib.ML.Utils.ActivationFunctions
{
    public interface IActivationFunction : ICloneable
    {
        void Activate(double[] neurons, int start, int size);

        double Derivate(double a);

        //Used for serializing
        string FullTypeName { get; }
    }
}
