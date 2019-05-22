using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}
