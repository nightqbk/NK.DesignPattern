using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.YanMo
{
    public class Client
    {
        public static void Test()
        {
            Api api = Factory.CreateApi(1);
            api.operation("test");
            Console.ReadKey();
        }
    }
}
