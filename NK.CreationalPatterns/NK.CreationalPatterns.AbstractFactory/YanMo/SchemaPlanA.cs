using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class SchemaPlanA : IAbstractFactory
    {
        public ICPU CreateCUP()
        {
            return new IntelCPU(55);
        }

        public IMainBoard CreateMainBoard()
        {
            return new GAMainBoard(55);
        }
    }
}
