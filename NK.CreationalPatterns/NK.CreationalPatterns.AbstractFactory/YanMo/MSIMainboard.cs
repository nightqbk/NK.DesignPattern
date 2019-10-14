using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class MSIMainboard : IMainBoard
    {
        private int cpuHoles = 0;

        public MSIMainboard(int cpuHoles)
        {
            this.cpuHoles = cpuHoles;
        }
        public void InstallCUP()
        {
            Console.WriteLine("Now, in the MSI Mainboard, cpuHoles=" + cpuHoles);
        }
    }
}
