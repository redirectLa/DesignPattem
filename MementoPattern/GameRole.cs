using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class GameRole
    {
        public int Vitality { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public void InitState()
        {
            Vitality = 100;
            Attack = 100;
            Defense = 100;
        }

        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Vitality, Attack, Defense);
        }

        public void RecoveryState(RoleStateMemento roleStateMemento)
        {
            this.Attack = roleStateMemento.Attack;
            this.Defense = roleStateMemento.Defense;
            this.Vitality = roleStateMemento.Vitality;
        }

        public void Fight()
        {
            this.Attack = 1;
            this.Defense = 1;
            this.Vitality = 1;
            Console.WriteLine("大战boss，属性降低到最低点了..");
        }

        public void StateDisplay()
        {
            Console.WriteLine($"当前状态：生命力:{Vitality},攻击力:{Attack},防御力:{Defense}");
        }

    }

    public class RoleStateMemento
    {
        public RoleStateMemento(int vitality, int attack, int defense)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
        }

        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; set; }

    }

    public class RoleStateCaretaker
    {
        private RoleStateMemento roleStateMemento;

        public RoleStateMemento RoleStateMemento
        {
            get => roleStateMemento;
            set => roleStateMemento = value;
        }
    }
}
