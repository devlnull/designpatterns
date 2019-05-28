using Creational.FactoryMathod;
using Structural.Composite;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("leaf A"));
            root.Add(new Leaf("leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("leaf XA"));
            comp.Add(new Leaf("leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);

            Console.ReadKey();
        }
    }
}
