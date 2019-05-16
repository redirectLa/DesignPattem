using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.BaseService;

namespace StrategyPattern.Services
{
    /// <summary>
    /// 方案B，满300减80
    /// </summary>
    public class StrategyServiceB : StrategyBase
    {
        public override double GetResult(double money)
        {
            return money;
        }
    }
}
