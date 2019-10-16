using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.BigTalk
{
    public class TestClient
    {
        public static void Test()
        {
            var builder = new ThinPersonBuilder(null, null);
            var director = new PersonDirector(builder);
            director.CreatePerson();
        }
    }
}
