using MachineLearning.ML.Data;
using MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork;
using MachineLearning.ML.Neural.Networks.Training.Gradient.Worker;
using MachineLearning.ML.Utils;
using MachineLearning.ML.Utils.Array;
using MachineLearning.ML.Utils.ErrorFunction;
using MachineLearning.ML.Utils.MathUtils;
using MachineLearning.ML.Utils.Threading.SuperQueue;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MachineLearning.ML.Neural.Networks.Training.Propagation
{
    abstract class Propagator
    {

        /// <summary>
        /// The owner of the propagator
        /// </summary>
        ForwardPropagationNetwork _network;


        /// <summary>
        /// Data that will be processed
        /// </summary>
        IMLDataSet _dataSet;


        /// <summary>
        /// Error function
        /// </summary>
        IErrorFunction _errorFunction;


        /// <summary>
        /// Gradients workers 
        /// </summary>
        GradientWorker[] _workers;

        int _numThreads;

        int _batchSize;

        double _totalError;

        double[] _gradients;

        double[] _lastGradients;


        object _mutex = new object();

       

        public Propagator(ForwardPropagationNetwork network, IMLDataSet DataSet, int BatchSize = 0, int numThreads = 0, IErrorFunction function = null)
        {
            this._network = network;
            this._dataSet = DataSet;
            this._batchSize = BatchSize;
            this._numThreads = numThreads == 0 ? (Environment.ProcessorCount) : (numThreads);

            _gradients = new double[network.NumWeights];

            _lastGradients = new double[network.NumWeights];

            _errorFunction = function == null ? (new LinearErrorFunction()) : (function);
        }


        //Processes the full dataset
        public void Iterate()
        {
            ArrayEngine.SetValue(_gradients, 0);

            GradientWorkload workload = new GradientWorkload(MLUtils.Multithreaded ? (_numThreads) : (1), _dataSet.Count, _batchSize);

            InitWorkers();

            _totalError = 0;

            while (!workload.EndOfDataSet)
            {
                workload.CalculateRanges();
                var ranges = workload.Ranges;

                if(MLUtils.Multithreaded == true)
                {
                    Parallel.For(0, ranges.Count, (i) =>
                    {
                        _workers[i].Train(_dataSet, ranges[i].Low, ranges[i].High);
                    });
                }
                else
                {
                    for (int i = 0; i < ranges.Count; ++i)
                        _workers[i].Train(_dataSet, ranges[i].Low, ranges[i].High );
                }

                _totalError /= ranges.Count;

                Learn();

                ArrayEngine.SetValue(_gradients, 0);
                workload.AdvanceIteration();
            }
        }


        void Learn()
        {
            for(int i =0; i < _gradients.Length; ++i)
            {
                _network.Weights[i] += UpdateWeights(_gradients, _lastGradients, i);
            }
        }

        void InitWorkers()
        {
            if(_workers == null)
            {
                _workers = new GradientWorker[_numThreads];
                for (int i = 0; i < _workers.Length; ++i)
                {
                    _workers[i] = new GradientWorker(_network.CreateProxy(), this);
                }

            }


        }

        public void ReportProgress(double[] gradients, double error)
        {
            lock (_mutex)
            { 
                for (int i = 0; i < _gradients.Length; ++i)
                    _gradients[i] += gradients[i];

                _totalError += error;
            }
        }

        public abstract double UpdateWeights(double[] gradients, double[] lastGradients, int index);

        public int ThreadCount { get => _numThreads; set => _numThreads = value; }

        public IMLDataSet Data { get => _dataSet; set => _dataSet = value; }

        public int BatchSize { get => _batchSize; set => _batchSize = value; }

        public IErrorFunction ErrorFunction { get => _errorFunction; }
        
        public double Error { get => _totalError; }
    }
}
