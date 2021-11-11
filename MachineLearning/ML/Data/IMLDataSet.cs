using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Data
{
    interface IMLDataSet
    {
        public IEnumerable<IMLDataPair> NextEnumerator();

        public int Count { get; }
        public IMLDataPair this[int index] { get; }

    }
}
