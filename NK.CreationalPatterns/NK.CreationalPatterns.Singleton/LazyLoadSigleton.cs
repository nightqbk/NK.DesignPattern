using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.Singleton
{
    // 饿汉模式
    public class LazyLoadSigleton
    {
        // 设置为静态，所以在加载类的时候就创建了。使用的时候，肯定就已经创建了
        private static readonly LazyLoadSigleton lazyLoadSigleton = new LazyLoadSigleton();
        private LazyLoadSigleton() { }

        public static LazyLoadSigleton GetLazyLoadSigleton()
        {
            return lazyLoadSigleton;
        }

        public void OperateOne() { }

        public void OperateTwo() { }
    }
}
