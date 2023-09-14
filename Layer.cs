using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Layer
    {
        public List<Neuron> Neurons { get;}
        public int Count => Neurons ?.Count ?? 0;

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            // TODO Проверить все входные нейроны на соответствие типу

            Neurons = neurons;
        }
    }
}
