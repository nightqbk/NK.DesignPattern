using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Facade.YanMo
{
    public class Facade
    {
        /// <summary>
        /// 满足客户端的需求
        /// </summary>
        public void Test()
        {
            // 在内部实现的时候，可能会调用到内部的多个模块
            IModuleA moduleA = new ModuleA();
            moduleA.TestA();

            IModuleB moduleB = new ModuleB();
            moduleB.TestB();

            IModuleC moduleC = new ModuleC();
            moduleC.TestC();
        }
    }
}
