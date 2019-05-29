using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine($"当前时间{w.Hour},太困了，睡觉了。");
        }
    }
}
