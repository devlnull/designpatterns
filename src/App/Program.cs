using Behavioral.Observer;
using Structural.Decorator;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "X"));
            subject.Attach(new ConcreteObserver(subject, "Y"));
            subject.Attach(new ConcreteObserver(subject, "Z"));

            subject.SubjectState = "ABC";
            subject.Notify();

            Console.ReadKey();
        }
    }
}
