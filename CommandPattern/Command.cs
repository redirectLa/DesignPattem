using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public abstract class Command
    {
        protected Barbecuer Barbecuer;
        protected Command(Barbecuer barbecuer)
        {
            this.Barbecuer = barbecuer;
        }

        public abstract void ExcuteAction();
    }

    public class Barbecuer
    {
        public void Action()
        {
            Console.WriteLine("执行方法");
        }
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExcuteAction()
        {
            Barbecuer.Action();
        }
    }

    public class Invoker
    {
        private Command Command;

        public Invoker(Command command)
        {
            this.Command = command;
        }

        public void ExcuteCommand()
        {
            Command.ExcuteAction();
        }
    }

}
