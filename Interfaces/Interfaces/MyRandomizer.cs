using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class MyRandomizer:IRandomizable
    {
        public double GetRandomNum(double dUpperBound)
        {
            Random rnumGen = new Random();
            double seed = rnumGen.NextDouble();
            return seed * dUpperBound;
        }
    }
}
