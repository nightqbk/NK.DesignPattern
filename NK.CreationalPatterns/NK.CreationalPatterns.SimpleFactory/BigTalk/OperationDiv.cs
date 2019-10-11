using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.BigTalk
{
    public class OperationDiv : Operation
    {
        public override double Operate()
        {
            return NumberA / NumberB;
        }
    }
}
