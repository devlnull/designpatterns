using System;

namespace Behavioral.Observer
{
    public class ConcreteObserver : IObserver
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"Observer {_name}'s new state is {_observerState}");
        }

        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
