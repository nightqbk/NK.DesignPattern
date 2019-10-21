using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.Simple
{
    public class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
