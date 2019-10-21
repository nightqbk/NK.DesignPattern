using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.StructuralPatterns.Adapter.YanMo
{
    public class LogModel
    {
        public string LogId { get; set; }

        public string OperateUser { get; set; }

        public string LogContent { get; set; }

        public string OperateTime { get; set; }

        public override string ToString()
        {
            return $"logId={LogId}, operateUser={OperateUser}, operateTime={OperateTime}, LogContent={LogContent}";
        }

    }
}
