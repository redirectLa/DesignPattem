using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //介绍
                //    意图：动态地给一个对象添加一些额外的职责。就增加功能来说，装饰器模式相比生成子类更为灵活。

                //主要解决：一般的，我们为了扩展一个类经常使用继承方式实现，由于继承为类引入静态特征，并且随着扩展功能的增多，子类会很膨胀。

                //何时使用：在不想增加很多子类的情况下扩展类。

                //如何解决：将具体功能职责划分，同时继承装饰者模式。

                //关键代码： 1、Component 类充当抽象角色，不应该具体实现。 2、修饰类引用和继承 Component 类，具体扩展类重写父类方法。

                //应用实例： 1、孙悟空有 72 变，当他变成"庙宇"后，他的根本还是一只猴子，但是他又有了庙宇的功能。 2、不论一幅画有没有画框都可以挂在墙上，但是通常都是有画框的，并且实际上是画框被挂在墙上。在挂在墙上之前，画可以被蒙上玻璃，装到框子里；这时画、玻璃和画框形成了一个物体。

                //优点：装饰类和被装饰类可以独立发展，不会相互耦合，装饰模式是继承的一个替代模式，装饰模式可以动态扩展一个实现类的功能。

                //缺点：多层装饰比较复杂。

                //使用场景： 1、扩展一个类的功能。 2、动态增加功能，动态撤销。

                //注意事项：可代替继承。

                //概念：1.动态地给一个对象添加一个额外的职责，就增加功能来说，装饰模式比生成子类更加灵活、
                //      2.装饰器模式是利用SetComponent来对对象进行包装的，这样每个装饰对象的实现就和如何使用这个对象分离开了，每个装饰对象只关心自己的功能，不需要关心如何被添加到对象链当中（DPE）
                #region 装饰模式

                ConcreteComponent c = new ConcreteComponent();
                ConcreteDecoratorA d1 = new ConcreteDecoratorA();
                ConcreteDecoratorB d2 = new ConcreteDecoratorB();

                d1.SetComponent(c);
                d2.SetComponent(d1);

                d2.Operation();


                Person xc = new Person("小菜");

                Console.WriteLine("\n第一种装扮：");

                Sneakers pqx = new Sneakers();
                BigTrouser kk = new BigTrouser();
                TShirts dtx = new TShirts();

                pqx.Decorate(xc);
                kk.Decorate(pqx);
                dtx.Decorate(kk);
                dtx.Show();

                Console.WriteLine("\n第二种装扮：");

                LeatherShoes px = new LeatherShoes();
                Tie ld = new Tie();
                Suit xz = new Suit();

                px.Decorate(xc);
                ld.Decorate(px);
                xz.Decorate(ld);
                xz.Show();

                Console.WriteLine("\n第三种装扮：");
                Sneakers pqx2 = new Sneakers();
                LeatherShoes px2 = new LeatherShoes();
                BigTrouser kk2 = new BigTrouser();
                Tie ld2 = new Tie();

                pqx2.Decorate(xc);
                px2.Decorate(pqx);
                kk2.Decorate(px2);
                ld2.Decorate(kk2);

                ld2.Show();


                #endregion

            }

            catch (Exception e)
            {
                Console.WriteLine($"遇到异常,ErrorMsg：{e.Message}");
                Console.ReadLine();
            }
        }
    }
    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }

    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }

    class ConcreteDecoratorB : Decorator
    {

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior()
        {

        }
    }

    class Person
    {
        public Person()
        { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }

    class Finery : Person
    {
        protected Person component;

        //打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }


    class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤 ");
            base.Show();
        }
    }

    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }

    class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西装 ");
            base.Show();
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("领带 ");
            base.Show();
        }
    }

    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋 ");
            base.Show();
        }
    }
}
