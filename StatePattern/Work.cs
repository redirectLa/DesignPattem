using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    //抽象状态
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }

    public class Work
    {
        private State current;
        public Work()
        {
            current = new ForenoonState();
        }

        private double hour;
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }


        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
