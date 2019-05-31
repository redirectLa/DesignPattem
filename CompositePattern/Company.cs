using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company c);//增加
        public abstract void Remove(Company c);//移除
        public abstract void Display(int depth);//显示
        public abstract void LineOfDuty();//履行职责

    }

    class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();

        public ConcreteCompany(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Company component in children)
            {
                component.Display(depth + 2);
            }
        }

        //履行职责
        public override void LineOfDuty()
        {
            foreach (Company component in children)
            {
                component.LineOfDuty();
            }
        }

    }

    //人力资源部
    class HRDepartment : Company
    {
        public HRDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
        }

        public override void Remove(Company c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }


        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 员工招聘培训管理", name);
        }
    }

    //财务部
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
        }

        public override void Remove(Company c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理", name);
        }

    }
}
