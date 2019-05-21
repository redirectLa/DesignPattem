using System;

namespace ObserverPattern
{
    public class NBAObserver : IObserver
    {
        private ISubject _subject;

        private string _name;

        private string _observerState;

        public NBAObserver(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"{_observerState}{_name}停止观看NBA,继续工作！");
        }
    }
}