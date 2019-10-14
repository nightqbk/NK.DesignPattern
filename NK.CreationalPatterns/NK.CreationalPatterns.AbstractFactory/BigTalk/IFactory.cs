using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.BigTalk
{
    public interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}
