using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.BaseService;

namespace StrategyPattern.Services
{
    /// <summary>
    /// 方案A，不打折
    /// </summary>
    public class StrategyServiceA : StrategyBase
    {
        public override double GetResult(double money)
        {
            return money;
        }
    }
}
