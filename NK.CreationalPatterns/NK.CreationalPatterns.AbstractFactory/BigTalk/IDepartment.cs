using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.BigTalk
{
    public interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
