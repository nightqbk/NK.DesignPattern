using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.SimpleFactory.YanMo
{
    public class Factory
    {
        public static Api CreateApi(int condition)
        {
            if (condition == 1)
            {
                return new ImplA();
            }
            else if (condition == 2)
            {
                return new ImplB();
            }

            return null;
        }
    }
}
