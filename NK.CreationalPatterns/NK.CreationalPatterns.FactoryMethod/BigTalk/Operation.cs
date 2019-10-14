using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.BigTalk
{
    public abstract class Operation
    {
        public double NumberA { get; set; }

        public double NumberB { get; set; }

        public abstract double Operate();
    }
}
