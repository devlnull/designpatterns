using System;

namespace Structural.Composite
{
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(String name)
        {
            Name = name;
        }
    }
}
