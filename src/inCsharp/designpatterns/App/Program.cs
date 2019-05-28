using Creational.FactoryMathod;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = new ConcreteCreator1();
            SomeOperation(creator);
        }

        static void SomeOperation(ICreator creator)
        {
            Console.WriteLine("Woring on creator operation...");
            var instance = creator.Create();
            instance.Operate();
        }
    }
}
