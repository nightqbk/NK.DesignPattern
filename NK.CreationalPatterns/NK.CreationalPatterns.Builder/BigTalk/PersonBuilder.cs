using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NK.CreationalPatterns.Builder.BigTalk
{
    public abstract class PersonBuilder
    {
        private readonly Graphics graphics;
        private readonly Pen pen;

        public PersonBuilder(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

        public abstract void BuildHead();

        public abstract void BuildBody();

        public abstract void BuildArmLeft();

        public abstract void BuildArmRight();

        public abstract void BuildLegLeft();

        public abstract void BuildLegRight();
    }
}
