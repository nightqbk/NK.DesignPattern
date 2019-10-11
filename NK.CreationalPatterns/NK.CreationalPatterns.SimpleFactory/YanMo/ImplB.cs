using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.YanMo
{
    public class ImplB : Api
    {
        public void operation(string s)
        {
            Console.WriteLine($"ImplB s=={s}");
        }
    }
}
