using System;

namespace Structural.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operate()
        {
            base.Operate();
            Console.WriteLine("Decorator B");
        }
    }
}
