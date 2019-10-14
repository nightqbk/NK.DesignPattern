using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class IntelCPU : ICPU
    {
        private int pins = 0;

        public IntelCPU(int pins)
        {
            this.pins = pins;
        }

        public void Calculate()
        {
            Console.WriteLine("now in Intel CUP, pins=" + pins);
        }
    }
}
