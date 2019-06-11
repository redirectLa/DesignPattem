using System;
using System.Collections;

namespace FlyweightPattern
{
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }



    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体的Flyweight：" + extrinsicstate);

        }
    }

    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享的具体的Flyweight：" + extrinsicstate);

        }
    }

    //享元工厂
    public class FlyweightFactory
    {
        private Hashtable flywegihts = new Hashtable();

        public FlyweightFactory()
        {
            flywegihts.Add("X", new ConcreteFlyweight());
            flywegihts.Add("Y", new ConcreteFlyweight());
            flywegihts.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return (Flyweight)flywegihts[key];
        }
    }
}