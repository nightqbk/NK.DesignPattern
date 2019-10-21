using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.YanMo
{
    public interface IDbLogger
    {
        void CreateLog(LogModel log);

        void UpdateLog(LogModel log);

        void RemoveLog(LogModel log);

        List<LogModel> GetAllLogs();
    }
}
