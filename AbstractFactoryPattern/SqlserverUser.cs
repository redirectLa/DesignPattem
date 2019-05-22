using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在SqlServer中获取User的一条记录。。");
            return null;
        }

        public bool InsertUser(User user)
        {
            Console.WriteLine("在SqlServer中新增一条User信息。");
            return true;
        }

    }


}
