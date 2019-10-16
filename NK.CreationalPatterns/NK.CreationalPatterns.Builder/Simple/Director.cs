using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.Simple
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPart();
        }
    }
}
