using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.YanMo
{
    public class ImplA : Api
    {
        public void operation(string s)
        {
            Console.WriteLine($"ImplA s=={s}");
        }
    }
}
