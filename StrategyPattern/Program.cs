using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using StrategyPattern.BaseService;
using StrategyPattern.Services;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 策略模式(商场活动)
                //上端指定使用收费类
                var strategyA = new MarketContext(new StrategyServiceA());
                var moneyA = strategyA.GetResult(100);
                Console.WriteLine(moneyA);

                var strategyB = new MarketContext(new StrategyServiceB(100, 20));
                var moneyB = strategyB.GetResult(100);
                Console.WriteLine(moneyB);

                var strategyC = new MarketContext(new StrategyServiceC(0.8));
                var moneyC = strategyC.GetResult(100);
                Console.WriteLine(moneyC);

                //简单工厂
                var strategyFactory = new MarketContext("原价");
                var moneyD = strategyFactory.GetResult(100);
                Console.WriteLine(moneyD);

                //反射根据配置实例化对应收费类
                //注意：反射使用LoadFile时转换成基类会失败，因为load加载的是当前上下文环境，LoadFile创建的实例和当前上下文不一致
                var strategyService = strategyServices.FirstOrDefault(p => p.Name == "原价");
                var strategyE = new MarketContext((StrategyBase)Assembly.Load("StrategyPattern").CreateInstance($"StrategyPattern.Services.{strategyService.ClassName}", false, BindingFlags.Default, null, strategyService.ParaObject, null, null));
                var moneyE = strategyE.GetResult(100);
                Console.WriteLine(moneyE);
                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine($"遇到异常,ErrorMsg：{e.Message}");
                Console.ReadLine();
            }
        }

        public class StrategyService
        {
            public string Name { get; set; }
            public string ClassName { get; set; }

            public object[] ParaObject { get; set; }
        }

        private static List<StrategyService> strategyServices = new List<StrategyService>()
        {
            new StrategyService{ Name="原价", ClassName = "StrategyServiceA",ParaObject =new object[]{}},
            new StrategyService{Name="满一百减二十",ClassName = "StrategyServiceB",ParaObject =new object[]{100,20}},
            new StrategyService{Name="八折",ClassName = "StrategyServiceC",ParaObject =new object[]{0.8}}
        };
    }
}
