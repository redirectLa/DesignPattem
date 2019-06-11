using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    //演奏内容
    public class PlayContext
    {
        //演奏文本
        private string text { get; set; }

        public string PlayText
        {
            get { return text; }
            set { text = value; }
        }


    }

    //表达式类
    public abstract class Expression
    {
        //解释器
        public void Interpreter(PlayContext context)
        {
            if (context.PlayText.Length == 0)
            {
                return;
            }

            string playKey = context.PlayText.Substring(0, 1);
            context.PlayText = context.PlayText.Substring(2);
            double playValue = Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ")));
            context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ") + 1);
            Excute(playKey, playValue);
        }
        //执行
        public abstract void Excute(string key, double value);
    }

    public class Note : Expression
    {
        public override void Excute(string key, double value)
        {
            string note = "";
            switch (key)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
            }

            Console.WriteLine(note);
        }


    }

    public class Scale : Expression
    {
        public override void Excute(string key, double value)
        {
            string scale = "";
            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.WriteLine(scale);
        }
    }
}
