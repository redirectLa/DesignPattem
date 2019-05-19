using System;

namespace FactoryPattern
{
    /// <summary>
    /// 计算器操作简单工厂
    /// </summary>
    public class OperationFactory
    {
        public static Operation GetOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
                default: throw new NullReferenceException("暂不支持此操作！");
            }
            return operation;
        }

        public class Operation
        {
            public double NumberA { get; set; }
            public double NumberB { get; set; }

            public virtual double GetResult()
            {
                return 0;
            }
        }

        /// <summary>
        /// 加法操作类
        /// </summary>
        public class OperationAdd : Operation
        {
            public override double GetResult()
            {
                return NumberA + NumberB;
            }
        }

        /// <summary>
        /// 减法操作类
        /// </summary>
        public class OperationSub : Operation
        {
            public override double GetResult()
            {
                return NumberA - NumberB;
            }
        }

        /// <summary>
        /// 乘法操作类
        /// </summary>
        public class OperationMul : Operation
        {
            public override double GetResult()
            {
                return NumberA * NumberB;
            }
        }

        /// <summary>
        /// 除法操作类
        /// </summary>
        public class OperationDiv : Operation
        {
            public override double GetResult()
            {
                if (NumberB == 0) throw new Exception("被除数不能为0！");
                return NumberA / NumberB;
            }
        }
    }
}
