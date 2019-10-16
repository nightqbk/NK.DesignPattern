using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.Simple
{
    public class ConcreteBuilder : IBuilder
    {
        private IProduct resultProduct;

        public IProduct GetResult()
        {
            return resultProduct;
        }

        public void BuildPart()
        {
            // 构建某个部件的功能处理
        }
    }
}
