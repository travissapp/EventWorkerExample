using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventWorkerExample
{
    public interface IChecker
    {
        bool IsRunning { get; set; }        
        string LogObjectName { get; }        
        void RunCheck();        
        bool AllowRun { get; }
        int CheckInterval { get; }
    }
}
