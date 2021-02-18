using System;

namespace Structural.Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Operate()
        {
            Console.WriteLine("Core");
        }
    }
}
