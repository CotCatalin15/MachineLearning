using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Data.BasicData
{
    public class BasicDataSet : IMLDataSet
    {
        BasicDataPair[] _data;


        public BasicDataSet(double[][] Values, double[][] Targets)
        {
            if (Values.Length > Targets.Length)
                throw new Exception("Greater or equal number of target values required!");

            _data = new BasicDataPair[Values.Length];

            for(int i = 0; i < Values.Length; ++i)
                _data[i] = new BasicDataPair(Values[i], Targets[i]);
        }

        public BasicDataSet(BasicDataPair[] TrainingData)
        {
            _data = TrainingData;
        }

        public IMLDataPair this[int index]
        {
            get
            {
                return _data[index];
            }
        }

        public int Count => _data.Length;

        public IEnumerable<IMLDataPair> NextEnumerator()
        {
            foreach(var pair in _data)
            {
                yield return pair;
            }
        } 
    }
}
