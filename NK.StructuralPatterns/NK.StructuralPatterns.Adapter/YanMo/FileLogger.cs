using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.YanMo
{
    public class FileLogger : IFileLogger
    {
        public List<LogModel> ReadLogFile()
        {
            return new List<LogModel>();
        }

        public void WriteLogFile(List<LogModel> logs)
        {
            foreach (var log in logs)
            {
                Console.WriteLine(log.ToString());
            }
        }
    }
}
