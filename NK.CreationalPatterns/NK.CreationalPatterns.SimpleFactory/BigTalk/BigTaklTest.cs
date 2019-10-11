using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.BigTalk
{
    public class BigTaklTest
    {
        public static void Test()
        {
            var operation = SimpleFactory.GetOperation("+");
            operation.NumberA = 1;
            operation.NumberB = 2;
            var result = operation.Operate();
            Console.WriteLine(result);
        }
    }
}
