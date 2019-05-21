using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者抽象
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update(); 
    }
}
