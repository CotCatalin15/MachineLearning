using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Data
{
    public interface IMLDataSet
    {
        IEnumerable<IMLDataPair> NextEnumerator();

        int Count { get; }
        IMLDataPair this[int index] { get; }

    }
}
