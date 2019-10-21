using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.Simple
{
    public class TestClient
    {
        public static void Test()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            target.Request();
        }

    }
}
