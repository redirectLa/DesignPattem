using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine($"当前时间：{w.Hour},工作完成，下班回家。");
        }
    }
}
