using MachineLearningLib.ML.Neural.Networks.Propagation.ForwardNetwork;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MachineLearningLib.ML.Neural.Networks.Propagation
{
    /// <summary>
    /// Interface just to classify networks
    /// </summary>
    public interface IPropagationNetwork : ISerializable
    {
        ForwardPropagationNetwork Network { get; }

        void Forward(double[] input, double[] output);

    }
}
