﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton _singleton;

        private Singleton()
        {
        }

        public static Singleton GetSingleton()
        {
            if(_singleton == null)
            {
                _singleton = new Singleton();
            }

            return _singleton;
        }

        public void OperateOne() { }

        public void OperateTwo() { }
    }
}
