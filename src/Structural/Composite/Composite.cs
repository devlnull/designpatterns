using System;
using System.Collections.Generic;

namespace Structural.Composite
{
    public class Composite : Component
    {
        public List<Component> Children { get; }
        public Composite(String name) : base(name)
        {
            Children = new List<Component>();
        }

        public override void Add(Component component)
        {
            Children.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach(var child in Children)
            {
                child.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            Children.Remove(component);
        }
    }
}
