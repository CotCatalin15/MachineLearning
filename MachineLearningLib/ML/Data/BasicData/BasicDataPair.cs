using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Data.BasicData
{
    [Serializable]
    public struct BasicDataPair : IMLDataPair
    {
        double[] _values;
        double[] _targets;

        public BasicDataPair(double[] values, double[] target)
        {
            _values = values;
            _targets = target;
        }

        public double[] Values => _values;

        public double[] Target => _targets;
    }
}
