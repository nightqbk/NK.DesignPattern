using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.BigTalk
{

    public static class TestClient_Simple
    {
        public static void Test()
        {
            new ConcertCreator().Operation();
        }
    }

    public abstract class Creator
    {
        protected abstract Product GetProduct();

        public void Operation()
        {
            var product = GetProduct();
            product.Operation();
        }
    }

    public class ConcertCreator : Creator
    {
        protected override Product GetProduct()
        {
            return new ConcertProduct();
        }
    }

    public interface Product
    {
        void Operation();
    }

    public class ConcertProduct : Product
    {
        public void Operation()
        {
            Console.WriteLine($"ConcertProduct Operation");
        }
    }
}
