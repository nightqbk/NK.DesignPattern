using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NK.CreationalPatterns.Builder.BigTalk
{
    public class ThinPersonBuilder : PersonBuilder
    {
        public ThinPersonBuilder(Graphics graphics, Pen pen) : base(graphics, pen)
        {
        }

        public override void BuildArmLeft()
        {
            throw new NotImplementedException();
        }

        public override void BuildArmRight()
        {
            throw new NotImplementedException();
        }

        public override void BuildBody()
        {
            throw new NotImplementedException();
        }

        public override void BuildHead()
        {
            throw new NotImplementedException();
        }

        public override void BuildLegLeft()
        {
            throw new NotImplementedException();
        }

        public override void BuildLegRight()
        {
            throw new NotImplementedException();
        }
    }
}
