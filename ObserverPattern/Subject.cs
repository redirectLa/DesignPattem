using System.Collections;
using System.Collections.Generic;

namespace ObserverPattern
{

    public abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            if (observer != null) observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            if (observer != null) observers.Remove(observer);
        }

        public void Notify()
        {
            if (observers.Count <= 0) return;
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

      

    }
}