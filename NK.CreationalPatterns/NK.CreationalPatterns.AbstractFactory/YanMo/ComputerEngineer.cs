using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.CreationalPatterns.AbstractFactory.YanMo
{
    public class ComputerEngineer
    {
        private ICPU cup = null;

        private IMainBoard mainBoard = null;

        public void MakeCoumputer(IAbstractFactory schema)
        {
            // 1. 准备硬件
            PrepareHardWares(schema);
            // 2. 安装硬件和系统
        }

        private void PrepareHardWares(IAbstractFactory schema)
        {
            this.cup = schema.CreateCUP();
            this.mainBoard = schema.CreateMainBoard();
        }
    }
}
