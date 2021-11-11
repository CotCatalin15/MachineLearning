using MachineLearning.ML.Data;
using MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork;
using MachineLearning.ML.Utils.ErrorFunction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Neural.Networks.Training.Propagation.Resilient
{
    class ResilientPropagation : Propagator
    {

        /// <summary>
        /// The last deltas.
        /// </summary>
        private readonly double[] _lastDelta;

        /// <summary>
        /// The last weight changed.
        /// </summary>
        private readonly double[] _lastWeightChanged;

        /// <summary>
        /// The maximum step value for rprop.
        /// </summary>
        ///
        private readonly double _maxStep;

        /// <summary>
        /// The update values, for the weights and thresholds.
        /// </summary>
        ///
        private readonly double[] _updateValues;

        /// <summary>
        /// The zero tolerance.
        /// </summary>
        ///
        private readonly double _zeroTolerance;

        /// <summary>
        /// The last error.
        /// </summary>
        private double _lastError;




        public ResilientPropagation(ForwardPropagationNetwork network, IMLDataSet DataSet, int BatchSize = 0, int numThreads = 0, IErrorFunction function = null) :
            base(network, DataSet, BatchSize, numThreads, function)
        {

            _updateValues = new double[network.NumWeights];
            _zeroTolerance = RPROPConst.DefaultZeroTolerance;
            _maxStep = RPROPConst.DefaultMaxStep;
            _lastWeightChanged = new double[network.NumWeights];
            _lastDelta = new double[network.NumWeights];

            for (int i = 0; i < _updateValues.Length; i++)
            {
                _updateValues[i] = RPROPConst.DefaultInitialUpdate;
            }

        }


        private int Sign(double v)
        {
            if (Math.Abs(v) < _zeroTolerance)
            {
                return 0;
            }
            if (v > 0)
            {
                return 1;
            }
            return -1;
        }


        public override double UpdateWeights(double[] gradients, double[] lastGradient, int index)
        {
            // multiply the current and previous gradient, and take the
            // sign. We want to see if the gradient has changed its sign.
            int change = Sign(gradients[index] * lastGradient[index]);
            double weightChange = 0;

            // if the gradient has retained its sign, then we increase the
            // delta so that it will converge faster
            if (change > 0)
            {
                double delta = UpdateValues[index]
                               * RPROPConst.PositiveEta;
                delta = Math.Min(delta, _maxStep);
                weightChange = Sign(gradients[index]) * delta;
                UpdateValues[index] = delta;
                lastGradient[index] = gradients[index];
            }
            else if (change < 0)
            {
                // if change<0, then the sign has changed, and the last
                // delta was too big
                double delta = UpdateValues[index]
                               * RPROPConst.NegativeEta;
                delta = Math.Max(delta, RPROPConst.DeltaMin);
                UpdateValues[index] = delta;
                weightChange = -_lastWeightChanged[index];
                // set the previous gradient to zero so that there will be no
                // adjustment the next iteration
                lastGradient[index] = 0;
            }
            else if (change == 0)
            {
                // if change==0 then there is no change to the delta
                double delta = _updateValues[index];
                weightChange = Sign(gradients[index]) * delta;
                lastGradient[index] = gradients[index];
            }

            _lastWeightChanged[index] = weightChange;

            // apply the weight change, if any
            return weightChange;
        }


        /// <value>The RPROP update values.</value>
        public double[] UpdateValues
        {
            get { return _updateValues; }
        }

    }
}
