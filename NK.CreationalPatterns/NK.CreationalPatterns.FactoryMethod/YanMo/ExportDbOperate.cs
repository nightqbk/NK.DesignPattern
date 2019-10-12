using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.YanMo
{
    public class ExportDbOperate : ExportOperate
    {
        protected override ExportFileApi GetFileApi()
        {
            return new ExportDB();
        }
    }
}
