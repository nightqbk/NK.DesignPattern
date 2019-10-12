using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.YanMo
{
    public class TestClient
    {
        public static void Test()
        {
            new ExportDbOperate().Export("Test");
            Console.ReadKey();
        }
    }
}
