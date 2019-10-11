using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.BigTalk
{
    public class SimpleFactory
    {
        public static Operation GetOperation(string type)
        {
            switch (type)
            {
                case "+":
                    return new OperationAdd();
                case "-":
                    return new OperationSub();
                case "*":
                    return new OperationMul();
                case "/":
                    return new OperationDiv();
                default:
                    throw new Exception("Can not find the type");
            }

        }
    }
}
