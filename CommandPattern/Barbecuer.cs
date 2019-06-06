using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Barbecuer
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串");
        }

        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅");
        }
    }

    public abstract class Command
    {
        protected Barbecuer receiver;

        protected Command(Barbecuer barbecuer)
        {
            this.receiver = barbecuer;
        }

        public abstract void ExcuteCommand();
    }


    public class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }

    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }

    public class Waiter
    {
        private IList<Command> commands = new List<Command>();

        public void SetOrder(Command command)
        {
            if (command.ToString() == "CommandPattern.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：不好意思，鸡翅卖完了！");
            }
            else
            {
                commands.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() + "时间:" + DateTime.Now);
            }
        }

        public void CancelOrder(Command command)
        {
            commands.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() + "时间:" + DateTime.Now);
        }

        //执行所有命令
        public void Notify()
        {
            foreach (var command in commands)
            {
                command.ExcuteCommand();
            }
        }
    }
}
