using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.BaseService
{
    /// <summary>
    /// 策略基类
    /// </summary>
    public abstract class StrategyBase
    {
        /// <summary>
        /// 获取折扣后金额
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public abstract double GetResult(double money);
    }
}
