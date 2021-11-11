using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningLib.ML.Utils.Array
{
    public static class ArrayEngine
    {

        public static T[] CloneArray<T>(T[] array)
        {
            T[] newArray = new T[array.Length];

            for (int i = 0; i < array.Length; ++i)
                newArray[i] = array[i];

            return newArray;
        }

        public static void Copy<T>(T[] dst, int dstOffset, T[] src, int srcOffset, int size)
        {
            if (size == 0)
                size = dst.Length;

            for(int i = 0; i < size; ++i)
            {
                dst[dstOffset + i] = src[srcOffset + i];
            }

        }   

        public static void Copy<T>(T[] dst, T[] src, int size)
        {
            Copy<T>(dst, 0, src, 0, size);
        }
 

        public static void Copy<T>(T[] dst, T[] src)
        {
            Copy<T>(dst, 0, src, 0, dst.Length);
        }

        public static void SetValue<T>(T[] dst, T val)
        {
            for (int i = 0; i < dst.Length; ++i)
                dst[i] = val;
        }
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        public static (int, double) GreatestValue(double[] values)
        {
            int maxIndex = 0;
            double maxVal = values[0];

            for(int i = 1; i < values.Length; ++i)
            {
                if(values[i] > maxVal)
                {
                    maxVal = values[i];
                    maxIndex = i;
                }
            }

            return (maxIndex, maxVal);
        }

    }
}
