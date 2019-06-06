using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    //手机软件
    public abstract class HandsetSoft
    {
        public abstract void Run();
    }

    public class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }

    public class HandsetAddressList : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机通讯录");
        }
    }

    //手机品牌
    abstract class HandsetBrand
    {
        protected HandsetSoft HandsetSoft;

        protected HandsetBrand(HandsetSoft handsetSoft)
        {
            this.HandsetSoft = handsetSoft;
        }

        public abstract void Run();
    }

    class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            base.HandsetSoft.Run();
        }

        public HandsetBrandM(HandsetSoft handsetSoft) : base(handsetSoft)
        {
        }
    }

    class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            base.HandsetSoft.Run();
        }

        public HandsetBrandN(HandsetSoft handsetSoft) : base(handsetSoft)
        {
        }
    }
}
