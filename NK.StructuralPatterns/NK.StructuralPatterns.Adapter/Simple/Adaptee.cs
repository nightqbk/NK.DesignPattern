using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.Simple
{
    /// <summary>
    /// 已经存在的接口，这个接口需要被适配
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee.SpecificRequest");
        }
    }
}
