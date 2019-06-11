using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    //状态
    public abstract class Action
    {
        //得到男人结论或反应
        public abstract void GetManConclusion(Person person);
        //得到女人结论或反应
        public abstract void GetWoManConclusion(Person person);

    }

    //人
    public abstract class Person
    {
        //接受
        public abstract void Accept(Action visitor);
    }
    //成功
    public class Success : Action
    {
        public override void GetManConclusion(Person person)
        {
            Console.WriteLine("manSuccess,name:{0}", this.GetType().Name);
        }

        public override void GetWoManConclusion(Person person)
        {
            Console.WriteLine("womanSuccess,name:{0}", this.GetType().Name);
        }
    }

    //成功
    public class Failing : Action
    {
        public override void GetManConclusion(Person person)
        {
            Console.WriteLine("manFailing,name:{0}", this.GetType().Name);
        }

        public override void GetWoManConclusion(Person person)
        {
            Console.WriteLine("womanFailing,name:{0}", this.GetType().Name);
        }
    }

    //恋爱
    public class Amativeness : Action
    {
        public override void GetManConclusion(Person person)
        {
            Console.WriteLine("manAmativeness,name:{0}", this.GetType().Name);
        }

        public override void GetWoManConclusion(Person person)
        {
            Console.WriteLine("womanAmativeness,name:{0}", this.GetType().Name);
        }
    }


    public class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion(this);

        }
    }

    public class WoMan : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWoManConclusion(this);

        }
    }

    public class ObjectStructrue
    {
        private List<Person> persons = new List<Person>();

        public void Attach(Person person)
        {
            persons.Add(person);
        }

        public void Detach(Person person)
        {
            persons.Remove(person);
        }

        public void Display(Action action)
        {
            foreach (var person in persons)
            {
                person.Accept(action);
            }
        }

    }
}