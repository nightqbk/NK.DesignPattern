using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.Singleton
{
    public class SingletonDoubleCheckLocking
    {
        private static SingletonDoubleCheckLocking _instance;
        private static readonly object lockObject = new object();
        private SingletonDoubleCheckLocking() { }

        public static SingletonDoubleCheckLocking GetSingleton()
        {
            if (_instance == null)
            {
                // 当多线程的时候，有可能两个线程一起到这边，所以lock上，排队进入
                lock (lockObject)
                {
                    // 当第一个线程进入的时候，给_instance 赋值
                    // 当第二个线程进入的时候，需要判断，要不然会重新new 一个对象，就不是单例了
                    if (_instance == null)
                    {
                        _instance = new SingletonDoubleCheckLocking();
                    }
                }
            }

            return _instance;
        }

        public void OperateOne() { }

        public void OperateTwo() { }
    }
}
