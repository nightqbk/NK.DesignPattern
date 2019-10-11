using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.BigTalk
{
    public class OperationAdd : Operation
    {
        public override double Operate()
        {
            return NumberA + NumberB;
        }
    }
}
