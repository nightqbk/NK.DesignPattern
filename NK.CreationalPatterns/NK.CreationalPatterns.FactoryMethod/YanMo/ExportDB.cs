using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.YanMo
{
    public class ExportDB : ExportFileApi
    {
        public bool Export(string data)
        {
            Console.WriteLine($"ExportDB data={data}");
            return true;
        }
    }
}
