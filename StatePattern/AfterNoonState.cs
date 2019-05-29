using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class AfterNoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine($"当前时间:{w.Hour}。下午时间，状态不错，全力工作！");
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}
