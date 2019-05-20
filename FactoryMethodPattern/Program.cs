using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //概念:1.简单工厂模式的最大优点在于工厂类中包含了必要的逻辑判断，根据客户端的选择动态的实例话对象的类，
                //对于客户端来说，去除了与具体产品的依赖。
                //     2.工厂方法模式定义了一个创建对象的接口，让子类决定实例化哪一个类，工厂方法让一个类的实例化延迟到了子类
                IFactory operFactory = new AddFactory();
                Operation oper = operFactory.CreateOperation();
                oper.NumberA = 1;
                oper.NumberB = 2;
                double result = oper.GetResult();

                Console.WriteLine(result);
            }

            catch (Exception e)
            {
                Console.WriteLine($"遇到异常,ErrorMsg：{e.Message}");
                Console.ReadLine();
            }
        }
    }
}
