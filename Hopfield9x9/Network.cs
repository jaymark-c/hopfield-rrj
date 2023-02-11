using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopfield9x9
{
    public class Network
    {
        //private static readonly Neuron[] nrn = new Neuron[9];
        private static readonly Neuron[] nrn = new Neuron[9];
        public int[] output = new int[9];

        public Network(int[] wt1, int[] wt2, int[] wt3, int[] wt4, int[] wt5, int[] wt6, int[] wt7, int[] wt8, int[] wt9)
        {
            nrn[0] = new Neuron(wt1);
            nrn[1] = new Neuron(wt2);
            nrn[2] = new Neuron(wt3);
            nrn[3] = new Neuron(wt4);
            nrn[4] = new Neuron(wt5);
            nrn[5] = new Neuron(wt6);
            nrn[6] = new Neuron(wt7);
            nrn[7] = new Neuron(wt8);
            nrn[8] = new Neuron(wt9);
        }

        public int threshld(int k)
        {
            if (k >= 0)
               return 1; //black
            else
               return -1; //white
        }

        public void activation(int[] patrn)
        {
            for(int i = 0; i < patrn.Length; i++)
            {
                for(int j=0; j< patrn.Length; j++)
                {
                    Console.WriteLine("\n nrn[" + i + "]weightv[" + j + "] is " + nrn[i].weightv[j]);
                }
                nrn[i].activation = nrn[i].act(patrn.Length, patrn);
                Console.WriteLine("\n activation is " + nrn[i].activation);
                output[i] = threshld(nrn[i].activation);
                Console.WriteLine("\n output value is " + output[i]);
            }
        }
    }
}
