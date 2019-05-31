using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    //发起
    public class Originator
    {
        private string state { get; set; }

        public string State
        {
            get => state;
            set => state = value;
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine($"State:{state}");
        }
    }

    //备忘录
    public class Memento
    {
        public string State { get; set; }

        public Memento(string state)
        {
            State = state;
        }
    }

    //管理者
    public class Caretaker
    {
        public Memento Memento { get; set; }

    }
}
