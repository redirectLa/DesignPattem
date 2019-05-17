using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.BaseService;

namespace StrategyPattern.Services
{
    /// <summary>
    /// 方案B，满100减30
    /// </summary>
    public class StrategyServiceB : StrategyBase
    {
        private double _fullMoney { get; set; }

        private double _subMoney { get; set; }

        public StrategyServiceB(double fullMoney, double subMoney)
        {
            _fullMoney = fullMoney;
            _subMoney = subMoney;
        }

        public override double GetResult(double money)
        {
            return _fullMoney > money ? money : money - _subMoney;
        }
    }
}
