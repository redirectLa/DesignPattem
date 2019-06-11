using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //介绍
            //    意图：给定一个语言，定义它的文法表示，并定义一个解释器，这个解释器使用该标识来解释语言中的句子。

            //主要解决：对于一些固定文法构建一个解释句子的解释器。

            //何时使用：如果一种特定类型的问题发生的频率足够高，那么可能就值得将该问题的各个实例表述为一个简单语言中的句子。这样就可以构建一个解释器，该解释器通过解释这些句子来解决该问题。

            //如何解决：构建语法树，定义终结符与非终结符。

            //关键代码：构建环境类，包含解释器之外的一些全局信息，一般是 HashMap。

            //应用实例：编译器、运算表达式计算。

            //优点： 1、可扩展性比较好，灵活。 2、增加了新的解释表达式的方式。 3、易于实现简单文法。

            //缺点： 1、可利用场景比较少。 2、对于复杂的文法比较难维护。 3、解释器模式会引起类膨胀。 4、解释器模式采用递归调用方法。

            //使用场景： 1、可以将一个需要解释执行的语言中的句子表示为一个抽象语法树。 2、一些重复出现的问题可以用一种简单的语言来进行表达。 3、一个简单语法需要解释的场景。

            //注意事项：可利用场景比较少，JAVA 中如果碰到可以用 expression4J 代替。

            Context context = new Context();
            List<AbstractExpression> expressions = new List<AbstractExpression>();
            expressions.Add(new TerminalExpression());
            expressions.Add(new NonTerminalExpression());
            expressions.Add(new TerminalExpression());
            expressions.Add(new TerminalExpression());

            foreach (var expression in expressions)
            {
                expression.Interpret(context);
            }


            PlayContext playContext = new PlayContext();
            //音乐-上海滩
            Console.WriteLine("上海滩：");
            //context.演奏文本 = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 D 0.5 E 0.5 G 3 D 0.5 E 0.5 O 1 A 3 A 0.5 O 2 C 0.5 D 1.5 E 0.5 D 0.5 O 1 B 0.5 A 0.5 O 2 C 0.5 O 1 G 3 P 0.5 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 D 0.5 E 0.5 G 3 D 0.5 E 0.5 O 1 A 3 A 0.5 O 2 C 0.5 D 1.5 E 0.5 D 0.5 O 1 B 0.5 A 0.5 G 0.5 O 2 C 3 P 0.5 O 3 C 0.5 C 0.5 O 2 A 0.5 O 3 C 2 P 0.5 O 2 A 0.5 O 3 C 0.5 O 2 A 0.5 G 2.5 G 0.5 E 0.5 A 1.5 G 0.5 C 1 D 0.25 C 0.25 D 0.5 E 2.5 E 0.5 E 0.5 D 0.5 E 2.5 O 3 C 0.5 C 0.5 O 2 B 0.5 A 3 E 0.5 E 0.5 D 1.5 E 0.5 O 3 C 0.5 O 2 B 0.5 A 0.5 E 0.5 G 2 P 0.5 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 D 0.5 E 0.5 G 3 D 0.5 E 0.5 O 1 A 3 A 0.5 O 2 C 0.5 D 1.5 E 0.5 D 0.5 O 1 B 0.5 A 0.5 G 0.5 O 2 C 3 ";
            playContext.PlayText = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
            //音乐-隐形的翅膀
            //Console.WriteLine("隐形的翅膀："); 
            //context.演奏文本 = "T 1000 O 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 E 1 D 0.5 C 0.5 C 0.5 C 0.5 C 0.5 O 1 A 0.25 G 0.25 G 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 G 0.5 D 0.25 E 0.25 D 0.5 C 0.25 D 0.25 D 1 A 0.5 G 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 E 0.5 D 0.5 C 0.5 C 0.25 D 0.25 O 1 A 1 G 0.5 A 0.5 O 2 C 1.5 D 0.25 E 0.25 D 1 E 0.5 C 0.5 C 3 O 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 E 1 D 0.5 C 0.5 C 0.5 C 0.5 C 0.5 O 1 A 0.25 G 0.25 G 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 G 0.5 D 0.25 E 0.25 D 0.5 C 0.25 D 0.25 D 1 A 0.5 G 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 E 0.5 D 0.5 C 0.5 C 0.25 D 0.25 O 1 A 1 G 0.5 A 0.5 O 2 C 1.5 D 0.25 E 0.25 D 1 E 0.5 C 0.5 C 3 E 0.5 G 0.5 O 3 C 1.5 O 2 B 0.25 O 3 C 0.25 O 2 B 1 A 0.5 G 0.5 A 0.5 O 3 C 0.5 O 2 E 0.5 D 0.5 C 1 C 0.5 C 0.5 C 0.5 O 3 C 1 O 2 G 0.25 A 0.25 G 0.5 D 0.25 E 0.25 D 0.5 C 0.25 D 0.25 D 3 E 0.5 G 0.5 O 3 C 1.5 O 2 B 0.25 O 3 C 0.25 O 2 B 1 A 0.5 G 0.5 A 0.5 O 3 C 0.5 O 2 E 0.5 D 0.5 C 1 C 0.5 C 0.5 C 0.5 O 3 C 1 O 2 G 0.25 A 0.25 G 0.5 D 0.25 E 0.25 D 0.5 C 0.5 C 3 ";
            Expression expression1 = null;
            try
            {
                while (playContext.PlayText.Length > 0)
                {
                    string str = playContext.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        case "O":
                            expression1 = new Scale();
                            break;
                        case "T":
                          //  expression1 = new Speed();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression1 = new Note();
                            break;

                    }
                    expression1.Interpreter(playContext);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
