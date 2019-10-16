using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.BigTalk
{
    public class PersonDirector
    {
        private PersonBuilder personBuilder;

        public PersonDirector(PersonBuilder personBuilder)
        {
            this.personBuilder = personBuilder;
        }

        public void CreatePerson()
        {
            personBuilder.BuildHead();
            personBuilder.BuildBody();
            personBuilder.BuildArmLeft();
            personBuilder.BuildArmRight();
            personBuilder.BuildLegLeft();
            personBuilder.BuildLegRight();
        }
    }
}
