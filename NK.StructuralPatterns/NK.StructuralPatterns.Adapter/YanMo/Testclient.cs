using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.YanMo
{
    public class TestClient
    {
        public static void Test()
        {
            IDbLogger dbLogger = new LogAdapter(new FileLogger());
        }
    }
}
