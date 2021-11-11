using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Utils.MathUtils
{
    /// <summary>
    /// A range of integers.
    /// </summary>
    public class IntRange
    {
        /// <summary>
        /// Construct an integer range.
        /// </summary>
        /// <param name="high">The high  end of the range.</param>
        /// <param name="low">The low end of the range.</param>
        public IntRange(int high, int low)
        {
            High = high;
            Low = low;
        }

        /// <summary>
        /// The low end of the range.
        /// </summary>
        public int High { get; set; }

        /// <summary>
        /// The high end of the range.
        /// </summary>
        public int Low { get; set; }
    }
}
