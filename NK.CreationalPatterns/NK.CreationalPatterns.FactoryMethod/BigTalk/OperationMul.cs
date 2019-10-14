using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.BigTalk
{
    public class OperationMul : Operation
    {
        public override double Operate()
        {
            return NumberA * NumberB;
        }
    }
}
