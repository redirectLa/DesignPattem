using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.BaseService;
using StrategyPattern.Services;

namespace StrategyPattern
{
    /// <summary>
    /// 策略上下文
    /// </summary>
    public class MarketContext
    {
        private StrategyBase strategyBase;

        public MarketContext(StrategyBase strategyBase)
        {
            this.strategyBase = strategyBase;
        }

        /// <summary>
        /// 简单工厂和策略模式结合
        /// </summary>
        /// <param name="strategyRule"></param>
        public MarketContext(string strategyRule)
        {
            switch (strategyRule)
            {
                case "原价":
                    strategyBase = new StrategyServiceA();
                    break;
                case "满一百减三十":
                    strategyBase = new StrategyServiceB(100, 30);
                    break;
                case "8折":
                    strategyBase = new StrategyServiceC(0.8);
                    break;
            }
        }



        public double GetResult(double money)
        {
            return strategyBase.GetResult(money);
        }


    }
}
