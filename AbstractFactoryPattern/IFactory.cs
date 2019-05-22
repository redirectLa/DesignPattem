using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IFactory
    {
        IUser CreateUser();
    }
}
