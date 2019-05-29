using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine($"当前时间:{w.Hour}。到中午了，该吃饭了。");
            }
            else
            {
                w.SetState(new AfterNoonState());
                w.WriteProgram();
            }
        }
    }
}
