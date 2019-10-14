using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.YanMo
{
    public class ExportTextFile : ExportFileApi
    {
        public bool Export(string data)
        {
            Console.WriteLine($"ExportTextFile data={data}");
            return true;
        }
    }
}
