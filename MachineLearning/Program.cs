using MachineLearning.ML.Data;
using MachineLearning.ML.Data.BasicData;
using MachineLearning.ML.Neural.Networks;
using MachineLearning.ML.Neural.Networks.Propagation;
using MachineLearning.ML.Neural.Networks.Propagation.ForwardNetwork;
using MachineLearning.ML.Neural.Networks.Training.Gradient.Worker;
using MachineLearning.ML.Neural.Networks.Training.Propagation.Backpropagation;
using MachineLearning.ML.Neural.Networks.Training.Propagation.Resilient;
using MachineLearning.ML.Utils.ActivationFunctions;
using System;
using System.Collections.Generic;

namespace MachineLearning
{
    class Program
    {
        static IMLDataSet DataSet;

        static int inputDataSize = 1200;

        static void GenerateData()
        {
            double[][] inputData = new double[inputDataSize][];
            double[][] targetData = new double[inputDataSize][];

            Random rand = new Random(DateTime.Now.Millisecond);

            for(int i = 0; i < inputDataSize; ++i)
            {
                double a = rand.NextDouble();
                double b = rand.NextDouble();

                inputData[i] = new double[] { a, b };
                targetData[i] = new double[] { a > b ? (1.0) : (0.0) };
            }

            DataSet = new BasicDataSet(inputData, targetData);
        }

        static void TrainNetwork(ForwardPropagationNetwork network)
        {
            GenerateData();

            ResilientPropagation propagation = new ResilientPropagation(network, DataSet, 0, 12);

            do
            {
                propagation.Iterate();
                Console.WriteLine(propagation.Error);
            } while (propagation.Error > 0.0001d);

            
        }

        static void FakeMain(string[] args)
        {
            ForwardPropagationNetwork network = new ParallelForwardNetwork(new BasicLayer[]{
                new BasicLayer(2, null),
                new BasicLayer(6, new SigmodFunction() ),
                new BasicLayer(1, new SigmodFunction() )
            });
            

            TrainNetwork(network);

            double maxValue = 1000;
            double[] outputs = new double[1];
            while(true)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                network.Forward(new double[] {  a / maxValue , b / maxValue }, outputs);

                if (outputs[0] > 0.5)
                {
                    Console.WriteLine("a > b");
                }
                else
                    Console.WriteLine("a < b");
            }


        }
    }
}
