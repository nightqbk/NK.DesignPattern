using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.YanMo
{
    public class LogAdapter : IDbLogger
    {
        private readonly IFileLogger fileLogger;

        public LogAdapter(IFileLogger fileLogger)
        {
            this.fileLogger = fileLogger;
        }

        public void CreateLog(LogModel log)
        {
            var logs = fileLogger.ReadLogFile();
            logs.Add(log);
            fileLogger.WriteLogFile(logs);
        }

        public List<LogModel> GetAllLogs()
        {
            return fileLogger.ReadLogFile();
        }

        public void RemoveLog(LogModel log)
        {
            var logs = fileLogger.ReadLogFile();
            logs.Remove(log);
            fileLogger.WriteLogFile(logs);
        }

        public void UpdateLog(LogModel log)
        {
            throw new NotImplementedException();
        }
    }
}
