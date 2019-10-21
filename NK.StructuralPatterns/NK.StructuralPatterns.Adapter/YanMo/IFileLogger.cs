using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.YanMo
{
    public interface IFileLogger
    {
        List<LogModel> ReadLogFile();

        void WriteLogFile(List<LogModel> logs);
    }
}
