using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Utils.ErrorCalculation
{
    public class ErrorCalculation
    {
        /// <summary>
        /// The current error calculation mode.
        /// </summary>
        private static ErrorCalculationMode _mode = ErrorCalculationMode.MSE;

        /// <summary>
        /// The overall error.
        /// </summary>
        private double _globalError;

        /// <summary>
        /// The size of a set.
        /// </summary>
        private int _setSize;

       
        public static ErrorCalculationMode Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        /// <summary>
        /// Returns the root mean square error for a complete training set. 
        /// </summary>
        /// <returns>The current error for the neural network.</returns>
        public double Calculate()
        {
            if (_setSize == 0)
            {
                return 0;
            }

            switch (Mode)
            {
                case ErrorCalculationMode.RMS:
                    return CalculateRMS();
                case ErrorCalculationMode.MSE:
                    return CalculateMSE();
                default:
                    return CalculateMSE();
            }
        }


        /// <summary>
        /// Calculate the error with MSE. 
        /// </summary>
        /// <returns>The current error for the neural network.</returns>
        public double CalculateMSE()
        {
            if (_setSize == 0)
            {
                return 0;
            }
            double err = _globalError / _setSize;
            return err;
        }


        /// <summary>
        /// Calculate the error with RMS. 
        /// </summary>
        /// <returns>The current error for the neural network.</returns>
        public double CalculateRMS()
        {
            if (_setSize == 0)
            {
                return 0;
            }
            double err = Math.Sqrt(_globalError / _setSize);
            return err;
        }



        /// <summary>
        /// Reset the error accumulation to zero.
        /// </summary>
        public void Reset()
        {
            _globalError = 0;
            _setSize = 0;
        }

        /// <summary>
        /// Called to update for each number that should be checked.
        /// </summary>
        /// <param name="actual">The actual number.</param>
        /// <param name="ideal">The ideal number.</param>
        /// <param name="significance">The significance of this error, 1.0 is the baseline.</param>
        public void UpdateError(double[] actual, double[] ideal, double significance)
        {
            for (int i = 0; i < actual.Length; i++)
            {
                double delta = ideal[i] - actual[i];

                _globalError += delta * delta;
            }

            _setSize += ideal.Length;
        }


        /// <summary>
        /// Update the error with single values.
        /// </summary>
        /// <param name="actual">The actual value.</param>
        /// <param name="ideal">The ideal value.</param>
        public void UpdateError(double actual, double ideal)
        {
            double delta = ideal - actual;

            _globalError += delta * delta;

            _setSize++;
        }

        /// <summary>
        /// Calculate the error as sum of squares.
        /// </summary>
        /// <returns>The error.</returns>
        public double CalculateSSE()
        {
            return _globalError / 2;
        }
    }
}
