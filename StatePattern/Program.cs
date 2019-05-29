using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //状态模式：当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类。
            //状态模式主要是解决的是当控制一个对象状态改变的条件表达式过于复杂的情况，把状态判断逻辑转移到表示不同状态一系类中，
            //可以把复杂的判断逻辑简化
            Work work = new Work();
            work.Hour = 8;
            work.WriteProgram();
            work.Hour = 10;
            work.WriteProgram();
            work.Hour = 12;
            work.WriteProgram();
            work.Hour = 14;
            work.WriteProgram();
            work.Hour = 17;
            work.WriteProgram();

            // work.TaskFinished = true;
            work.TaskFinished = false;
            work.WriteProgram();
            work.Hour = 19;
          
            work.WriteProgram();

            work.Hour = 22;
            work.WriteProgram();

            Console.ReadLine();
        }
    }
}
