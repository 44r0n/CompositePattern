using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Composite : Component
    {
        public override void Operation()
        {
            foreach (Component c in components)
            {
                c.Operation();
            }
            //Some ational stuff can be added.
        }

        private List<Component> components;

        protected Composite(string name)
        : base(name)
        {
            components = new List<Component>();
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }
        public override void Remove(Component component)
        {
            components.Remove(component);
        }
        public override IEnumerable<Component> CreateIterator
        {
            get
            {
                return components;
            }
        }
    }
}
