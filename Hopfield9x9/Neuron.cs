using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopfield9x9
{
    internal class Neuron
    {
        public int activation;
        public int[] weightv = new int[9];

        public Neuron() { }

        public Neuron(int[] j)
        {
            for(int i = 0; i < j.Length; i++)
            {
                weightv[i] = j[i];
            }
        }

        public int act(int m, int[] x)
        {
            int a = 0;
            for(int i=0; i<m; i++)
            {
                a += x[i] * weightv[i];
            }
            return a;
        }
    }
}
