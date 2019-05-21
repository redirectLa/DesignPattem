using System;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject _subject;

        private string _name;

        private string _observerState;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"观察者{_name}的新状态是{_observerState}");
        }
    }
}