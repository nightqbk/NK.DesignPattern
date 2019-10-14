using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.YanMo
{
    public class ExportTxtFileOperate : ExportOperate
    {
        protected override ExportFileApi GetFileApi()
        {
            return new ExportTextFile();
        }
    }
}
