using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Access中获取User的一条记录。。");
            return null;
        }

        public bool InsertUser(User user)
        {
            Console.WriteLine("在Access中新增一条User信息。");
            return true;
        }
    }
}
