using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class Client_AbstractFactory
    {
        public static void Test()
        {
            ComputerEngineer computerEngineer = new ComputerEngineer();
            IAbstractFactory schema = new SchemaPlanA();
            computerEngineer.MakeCoumputer(schema);
        }
    }
}
