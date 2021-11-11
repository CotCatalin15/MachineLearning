using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Data
{
    public interface IMLDataPair
    {
        double[] Values { get; }
        double[] Target { get; }
    }
}
