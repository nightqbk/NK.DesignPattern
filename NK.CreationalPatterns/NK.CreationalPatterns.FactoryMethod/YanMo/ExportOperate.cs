using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.FactoryMethod.YanMo
{
    public abstract class ExportOperate
    {
        protected abstract ExportFileApi GetFileApi();

        public bool Export(string data)
        {
            return GetFileApi().Export(data);
        }
    }
}
