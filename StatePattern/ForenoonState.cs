using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class ForenoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine($"当前时间:{w.Hour}。上午工作，精神百倍。");
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
}
