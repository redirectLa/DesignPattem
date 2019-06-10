using System;

namespace MediatorPattern
{
    //抽象中介者
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }

    public abstract class Colleague
    {
        protected Mediator Mediator;
        protected Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

        public abstract void Notify(string msg);
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string msg)
        {
            Mediator.Send(msg, this);
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("同事1收到消息{0}。", msg);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }
        public void Send(string msg)
        {
            Mediator.Send(msg, this);
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("同事2收到消息{0}。", msg);
        }
    }

    //具体中介者
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _concreteColleague1 { get; set; }

        private ConcreteColleague2 _concreteColleague2 { get; set; }


        public ConcreteColleague1 ConcreteColleague1
        {
            set { _concreteColleague1 = value; }
        }

        public ConcreteColleague2 ConcreteColleague2
        {
            set { _concreteColleague2 = value; }
        }

        public override void Send(string msg, Colleague colleague)
        {
            if (colleague == _concreteColleague1)
            {
                _concreteColleague1.Notify(msg);
            }
            else if (colleague == _concreteColleague2)
            {
                _concreteColleague2.Notify(msg);
            }
        }
    }
}