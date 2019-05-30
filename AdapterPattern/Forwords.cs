using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    //前锋
    public class Forwords : Player
    {
        public Forwords(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"前锋{Name}进攻！");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋{Name}防守！");
        }
    }

    //中锋
    public class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"中锋{Name}进攻！");
        }

        public override void Defense()
        {
            Console.WriteLine($"中锋{Name}防守！");
        }
    }

    //后卫
    public class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"后卫{Name}进攻！");
        }

        public override void Defense()
        {
            Console.WriteLine($"后卫{Name}防守！");
        }
    }

    //外籍中锋
    public class ForeignCenter
    {
        public string Name { get; set; }

        public ForeignCenter(string name)
        {
            this.Name = name;
        }

        public ForeignCenter()
        {
        }

        public void 进攻()
        {
            Console.WriteLine($"外籍中锋{Name}进攻！");
        }

        public void 防守()
        {
            Console.WriteLine($"外籍中锋{Name}防守！");
        }
    }

    public class Translator : Player
    {
        private ForeignCenter foreignCenter = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            foreignCenter.Name = name;
        }

        public override void Attack()
        {
            foreignCenter.进攻();
        }

        public override void Defense()
        {
            foreignCenter.防守();
        }
    }
}
