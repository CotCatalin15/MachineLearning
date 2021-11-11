using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Data
{
    public interface IMLDataPair
    {
        public double[] Values { get; }
        public double[] Target { get; }
    }
}
