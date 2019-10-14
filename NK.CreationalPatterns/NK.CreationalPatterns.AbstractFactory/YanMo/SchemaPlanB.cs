using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class SchemaPlanB : IAbstractFactory
    {
        public ICPU CreateCUP()
        {
            return new AMDCPU(66);
        }

        public IMainBoard CreateMainBoard()
        {
            return new MSIMainboard(66);
        }
    }
}
