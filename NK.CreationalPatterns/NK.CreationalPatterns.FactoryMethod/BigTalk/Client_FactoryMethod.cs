using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.FactoryMethod.BigTalk
{
    public class Client_FactoryMethod
    {
        public static void Test()
        {
            var operation = new MulFactory().CreateOperation();
            operation.NumberA = 1;
            operation.NumberB = 2;
            operation.Operate();

        }
    }
}
