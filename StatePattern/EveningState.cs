using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine($"当前时间:{w.Hour}。工作没完成，加班ing");

                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }

        }
    }
}
