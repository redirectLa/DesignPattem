using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.BaseService;

namespace StrategyPattern.Services
{
    /// <summary>
    /// 方案C(折扣)
    /// </summary>
    public class StrategyServiceC : StrategyBase
    {
        public StrategyServiceC(double haircutMoney)
        {
            _haircutMoney = haircutMoney;
        }

        private double _haircutMoney { get; set; }

        public override double GetResult(double money)
        {
            return money * _haircutMoney;
        }
    }
}
