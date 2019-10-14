using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.BigTalk
{
    public class TestClient_AbstractFactory
    {
        public static void Test()
        {
            IFactory factory = new SqlServerFactory();
            IUser user = factory.CreateUser();
            user.Insert(new User());
        }
    }
}
