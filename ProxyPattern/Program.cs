using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //概念:1.为其它对象提供一种代理以控制对这个对象的访问(DP)
                Proxy proxy = new Proxy();
                proxy.Request();

            }
            catch (Exception e)
            {
                Console.WriteLine($"遇到异常,ErrorMsg：{e.Message}");
                Console.ReadLine();
            }
        }

        abstract class Subject
        {
            public abstract void Request();
        }

        class RealSubject : Subject
        {
            public override void Request()
            {
                Console.WriteLine("真实的请求");
            }
        }

        class Proxy : Subject
        {
            RealSubject realSubject;
            public override void Request()
            {
                if (realSubject == null)
                {
                    realSubject = new RealSubject();
                }

                realSubject.Request();
            }
        }
    }
}
