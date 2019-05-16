using System;

namespace FactoryPattem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                #region  简单工厂（计算器）
                Console.WriteLine("请输入数字A");
                var numberA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入运算符号(+、-、*、/)");
                var operate = Console.ReadLine();
                Console.WriteLine("请输入数字B");
                var numberB = Convert.ToDouble(Console.ReadLine());

                var operation = OperationFactory.GetOperation(operate);
                operation.NumberA = numberA;
                operation.NumberB = numberB;
                Console.WriteLine(operation.GetResult());
                #endregion


            }
            catch (Exception e)
            {
                Console.WriteLine($"遇到异常,ErrorMsg：{e.Message}");
                Console.ReadLine();
            }
        }
    }
}
