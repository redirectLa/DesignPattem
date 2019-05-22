using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class SqlServerFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
}
