using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.BigTalk
{
    public class OperationSub : Operation
    {
        public override double Operate()
        {
            return NumberA - NumberB;
        }
    }
}
