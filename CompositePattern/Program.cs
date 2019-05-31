using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //组合模式:将对象组合成树形模式结构以表示“部分-整体”的层次结构，组合模式使得用户对单个对象和组合对象的使用具有一致性

            //介绍
            //    意图：将对象组合成树形结构以表示"部分-整体"的层次结构。组合模式使得用户对单个对象和组合对象的使用具有一致性。

            //主要解决：它在我们树型结构的问题中，模糊了简单元素和复杂元素的概念，客户程序可以向处理简单元素一样来处理复杂元素，从而使得客户程序与复杂元素的内部结构解耦。

            //何时使用： 1、您想表示对象的部分 - 整体层次结构（树形结构）。 2、您希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象。

            //如何解决：树枝和叶子实现统一接口，树枝内部组合该接口。

            //关键代码：树枝内部组合该接口，并且含有内部属性 List，里面放 Component。

            //应用实例： 1、算术表达式包括操作数、操作符和另一个操作数，其中，另一个操作符也可以是操作数、操作符和另一个操作数。 2、在 JAVA AWT 和 SWING 中，对于 Button 和 Checkbox 是树叶，Container 是树枝。

            //优点： 1、高层模块调用简单。 2、节点自由增加。

            //缺点：在使用组合模式时，其叶子和树枝的声明都是实现类，而不是接口，违反了依赖倒置原则。

            //使用场景：部分、整体场景，如树形菜单，文件、文件夹的管理。

            //注意事项：定义时为具体类。
            {
                Composite root = new Composite("root");
                root.Add(new Leaf("Leaf A"));
                root.Add(new Leaf("Leaf B"));

                Composite comp = new Composite("Composite X");
                comp.Add(new Leaf("Leaf XA"));
                comp.Add(new Leaf("Leaf XB"));
                root.Add(comp);

                Composite comp2 = new Composite("Composite XY");
                comp2.Add(new Leaf("Leaf XYA"));
                comp2.Add(new Leaf("Leaf XYB"));
                comp.Add(comp2);
                root.Add(new Leaf("Leaf C"));

                Leaf leafD = new Leaf("leaf D");
                root.Add(leafD);
                root.Remove(leafD);

                root.Display(1);
            }
            {
                ConcreteCompany root = new ConcreteCompany("北京总公司");
                root.Add(new HRDepartment("总公司人力资源部"));
                root.Add(new FinanceDepartment("总公司财务部"));

                ConcreteCompany comp = new ConcreteCompany("上海华东分公司");
                comp.Add(new HRDepartment("华东分公司人力资源部"));
                comp.Add(new FinanceDepartment("华东分公司财务部"));
                root.Add(comp);

                ConcreteCompany comp1 = new ConcreteCompany("南京办事处");
                comp1.Add(new HRDepartment("南京办事处人力资源部"));
                comp1.Add(new FinanceDepartment("南京办事处财务部"));
                comp.Add(comp1);

                ConcreteCompany comp2 = new ConcreteCompany("杭州办事处");
                comp2.Add(new HRDepartment("杭州办事处人力资源部"));
                comp2.Add(new FinanceDepartment("杭州办事处财务部"));
                comp.Add(comp2);


                Console.WriteLine("\n结构图：");

                root.Display(1);

                Console.WriteLine("\n职责：");

                root.LineOfDuty();
            }
            Console.ReadLine();
        }
    }
}
