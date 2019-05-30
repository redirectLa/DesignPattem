using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //适配器模式：将一个类的接口装换成客户需要的另一个接口，Adapter模式使得原本由于接口不兼容不能一起工作的类可以一起工作。

            Player aPlayer=new Forwords("巴蒂尔");
            aPlayer.Attack();

            Player bPlayer = new Center("麦克格雷迪");
            bPlayer.Attack();

            Player ymPlayer = new Translator("姚明");
            ymPlayer.Attack();
            ymPlayer.Defense();

            Console.ReadLine();
        }
    }
}
