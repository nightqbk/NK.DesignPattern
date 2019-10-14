using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.BigTalk
{
    public class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
