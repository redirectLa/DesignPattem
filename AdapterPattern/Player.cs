using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdapterPattern
{
    public abstract class Player
    {
        protected string Name { get; set; }

        protected Player(string name)
        {
            this.Name = name;
        }

        //进攻
        public abstract void Attack();
        //防守
        public abstract void Defense();

    }
}
