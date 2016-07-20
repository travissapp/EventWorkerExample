using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventWorkerExample
{
    abstract public class CheckerBase : IChecker
    {
        abstract public bool IsRunning { get; set; }

        abstract public string LogObjectName { get; }

        abstract public void RunCheck();

        abstract public bool AllowRun { get; }

        abstract public int CheckInterval { get; }

        public void LogException(Exception ex)
        {
           
            Log.WriteAndLog(string.Format("{0} Error at {1}: {2}", LogObjectName, DateTime.Now, ex.ToString()), LogObjectName);
            
        }
    }
}
