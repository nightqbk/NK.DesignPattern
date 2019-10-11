using NK.CreationalPatterns.SimpleFactory.BigTalk;
using NK.CreationalPatterns.SimpleFactory.YanMo;
using System;

namespace NK.CreationalPatterns.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            BigTaklTest.Test();
            Client.Test();
            Console.ReadKey();
        }
    }
}
