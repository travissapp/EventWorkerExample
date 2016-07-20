using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace EventWorkerExample
{

    public class StartUp : IStartUp
    {
        #region private classes

        private class MyChecker
        {
            public object CheckerInstance { get; set; }
        }


        private class MyTimer : IDisposable
        {
            public Timer PSCheckerTimer { get; set; }
            public TimerCallback PSTimerCallback { get; set; }
            public IChecker Checker { get; set; }

            public void Dispose()
            {
                if (PSCheckerTimer != null)
                    PSCheckerTimer.Dispose();
            }
        }
        #endregion


        List<MyChecker> checkerInstances;
        List<MyTimer> myTimers;

        public void Run()
        {
            myTimers = new List<MyTimer>();
            LoadCheckers();

            foreach(var checker in checkerInstances)
            {
                var c = (IChecker)checker.CheckerInstance;

                if (!c.AllowRun) continue;

                MyTimer myPSTimer = new MyTimer();
                myPSTimer.PSTimerCallback = new TimerCallback(IndividualCheckerTimerHandler);
                myPSTimer.PSCheckerTimer = new Timer(myPSTimer.PSTimerCallback, checker.CheckerInstance, c.CheckInterval, c.CheckInterval);
                myTimers.Add(myPSTimer);
            }
        }


        private void IndividualCheckerTimerHandler(Object obj)
        {
            var c = (IChecker)obj;

            if (!c.IsRunning)
            {
                RunCheck(c);
            }

        }


        private void RunCheck(IChecker c)
        {
            
            Thread thread = new Thread(c.RunCheck);
            thread.Start();
        }

        private void LoadCheckers()
        {
            checkerInstances = new List<MyChecker>();
            var types = GetCheckerAssemblies(typeof(CheckerBase));

            foreach (var mytype in types)
            {
                object checkerInstance = Activator.CreateInstance(mytype);
                var c = (IChecker)checkerInstance;           

                checkerInstances.Add(new MyChecker { CheckerInstance = checkerInstance });

            }
        }


        private IEnumerable<Type> GetCheckerAssemblies(Type type)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies().ToList()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);

            return types;
        }

        public void Stop()
        {
            
        }
    }
}
