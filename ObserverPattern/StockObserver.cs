using System;

namespace ObserverPattern
{
    public class StockObserver : IObserver
    {
        private ISubject _subject;

        private string _name;

        private string _observerState;

        public StockObserver(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"{_observerState}{_name}关闭股票行情,继续工作！");
        }
    }
}