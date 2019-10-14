using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.FactoryMethod.BigTalk
{
    public interface IFactory
    {
        Operation CreateOperation();
    }
}
