using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Facade.YanMo
{
    public class Client
    {
        public void Test()
        {
            new Facade().Test();
        }
    }
}
