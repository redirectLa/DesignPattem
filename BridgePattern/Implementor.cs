using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB");
        }
    }

    public class Abstraction
    {
        protected Implementor Implementor;

        protected Abstraction(Implementor implementor)
        {
            this.Implementor = implementor;
        }

        public virtual void Operation()
        {
            Implementor.Operation();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            Implementor.Operation();
        }
    }
}
