using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class GAMainBoard : IMainBoard
    {
        private int cpuHoles = 0;

        public GAMainBoard(int cpuHoles)
        {
            this.cpuHoles = cpuHoles;
        }
        public void InstallCUP()
        {
            Console.WriteLine("Now, in the GA Mainboard, cpuHoles=" + cpuHoles);
        }
    }
}
