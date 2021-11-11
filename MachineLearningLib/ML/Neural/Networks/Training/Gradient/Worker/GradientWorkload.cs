using MachineLearningLib.ML.Utils.MathUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Neural.Networks.Training.Gradient.Worker
{
    /// <summary>
    /// Calculates the workload required
    /// </summary>
    class GradientWorkload
    {

        private const int MinWorkload = 8; 

        /// <summary>
        /// Number of required workers
        /// </summary>
        int _numWorkers = 0;

        int _numThreads = 0;

        int _count = 0;

        int _batchSize = 0;


        int _itemsPerWorker = 0;

        int _rangeOffset = 0;

        List<IntRange> _ranges;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numThreads">Max number of threads</param>
        /// <param name="count">Total training data size</param>
        public GradientWorkload(int numThreads, int count, int batchSize)
        {
            _numThreads = numThreads;
            _count = count;
            _batchSize = batchSize;

            int ItemsPerWorker = 0;
            if (batchSize == 0)
                ItemsPerWorker = (int)Math.Ceiling(count / (double)numThreads);
            else
                ItemsPerWorker = (int)Math.Ceiling(batchSize / (double)numThreads);

            _ranges = new List<IntRange>();
            _itemsPerWorker = Math.Max(ItemsPerWorker, MinWorkload);
        }


        public void AdvanceIteration()
        {
            _rangeOffset += _batchSize == 0 ? (_count) : (_batchSize);
        }

        public void CalculateRanges()
        {
            int size = _batchSize == 0 ? (_count) : (_batchSize);
            int remainingItems = size;

            if (_rangeOffset + size > _count)
                size = _count - _rangeOffset;

            _ranges.Clear();

            int highSize = _rangeOffset + size;

            int current = _rangeOffset;
            while (current + _itemsPerWorker <= highSize)
            {
                _ranges.Add(new IntRange(current + _itemsPerWorker, current));
                current += _itemsPerWorker;
            }

            if (current < highSize)
            {
                _ranges.Add(new IntRange(highSize, current));
            }
        }

        public bool EndOfDataSet { get => _rangeOffset >= _count; }

        public int NumWorkers { get => _numWorkers; }

        public List<IntRange> Ranges { get => _ranges; }

    }
}
