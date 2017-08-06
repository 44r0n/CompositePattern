using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class Component
    {
        public abstract void Operation(); //Or whathever type.
        public virtual void Add(Component component)
        {
            throw new NotSupportedException("Add is not supported.");
        }
        public virtual void Remove(Component component)
        {
            throw new NotSupportedException("Remove is not supported.");
        }
        public virtual IEnumerable<Component> CreateIterator
        {
            get
            {
                return null;
            }
        }

        public string Name
        {
            get; set;
        }

        protected Component(string name)
        {
            this.Name = name;
        }
    }
}
