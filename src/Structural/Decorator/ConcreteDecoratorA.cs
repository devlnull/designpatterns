using System;

namespace Structural.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operate()
        {
            base.Operate();
            Console.WriteLine("Decorator A");
        }
    }
}
