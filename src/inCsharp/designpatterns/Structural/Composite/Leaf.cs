using System;

namespace Structural.Composite
{
    public class Leaf : Component
    {
        public Leaf(String name) : base(name)
        { }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
    }
}
