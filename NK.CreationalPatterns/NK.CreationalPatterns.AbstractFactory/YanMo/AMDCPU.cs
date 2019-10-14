using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class AMDCPU : ICPU
    {
        private int pins = 0;

        public AMDCPU(int pins)
        {
            this.pins = pins;
        }

        public void Calculate()
        {
            Console.WriteLine("now in AMD CUP, pins=" + pins);
        }
    }
}
