using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AbstractFactoryPattern
{
    public class DataAccess
    {
        //todo 可通过配置文件获取，动态切换
        private static readonly string dbStr = "SqlServer";
        private static readonly string AssemblyName = "AbstractFactoryPattern";

        public static IUser CreateUser()
        {
            //简单工厂实现
            //IUser iUser;
            //switch (dbStr)
            //{
            //    case "SqlServer":
            //        iUser = new SqlServerUser(); break;
            //    case "AccessServer":
            //        iUser = new AccessUser();
            //        break;
            //    default: iUser = new SqlServerUser(); break;
            // return iUser;
            //}

            return (IUser)Assembly.Load(AssemblyName).CreateInstance(AssemblyName + $".{dbStr}User");
        }





    }
}
