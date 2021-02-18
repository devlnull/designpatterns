﻿using System;

namespace Structural.Composite
{
    public abstract class Component
    {
        protected string Name { get; set; }
        public Component(String name)
        {
            Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }
}