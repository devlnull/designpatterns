using System;

namespace Structural.Composite
{
    public class Leaf : Component
    {
        public Leaf(String name) : base(name)
        { }

        public override string ToString()
        {
            return $"- {Name}";
        }
    }
}
