using System;

namespace InterpreterPattern
{
    //抽象解释器
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }


    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }

    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }

    public class Context
    {
        private string input { get; set; }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        private string output { get; set; }

        public string Output
        {
            get { return output; }
            set { output = value; }
        }


    }

}