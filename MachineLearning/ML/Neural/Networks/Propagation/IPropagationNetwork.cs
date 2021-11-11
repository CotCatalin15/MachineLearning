using MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.ML.Neural.Networks.Propagation
{
    /// <summary>
    /// Inteface just to clasify networks
    /// </summary>
    interface IPropagationNetwork
    {
        ForwardPropagationNetwork Network { get; }
    }
}
