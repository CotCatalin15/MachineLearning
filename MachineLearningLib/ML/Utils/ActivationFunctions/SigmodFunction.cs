﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningLib.ML.Utils.ActivationFunctions
{
    public class SigmodFunction : IActivationFunction
    {
        public string FullTypeName => typeof(SigmodFunction).FullName;
        public void Activate(double[] neurons, int start, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                double val = neurons[start + i];
                neurons[i + start] = 1.0d / (1.0d + Math.Exp(-val));
            }
        }

        public object Clone()
        {
            return (object)new SigmodFunction();
        }

        public double Derivate(double a)
        {
            return a * (1.0 - a);
        }

        

    }
}
