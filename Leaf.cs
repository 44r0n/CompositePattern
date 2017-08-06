using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Leaf : Component
    {
        public override void Operation()
        {
            //Do some stuff.
        }

        protected Leaf(string name)
        : base(name) { }
    }
}