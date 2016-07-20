using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EventWorkerExample
{
    public class NewSomethingElseChecker : CheckerBase
    {


        public override bool IsRunning
        {
            get;
            set;
        }

        public override string LogObjectName
        {
            get { return this.GetType().Name; }
        }

        public override bool AllowRun
        {
            get { return true; }
        }

        public override int CheckInterval
        {
            get { return 2000; }
        }



        public override void RunCheck()
        {

            if (AllowRun)
            {
                IsRunning = true;
                try
                {
                    Check();
                }
                catch (Exception ex)
                {
                    LogException(ex);
                }
                finally
                {
                    IsRunning = false;
                }
            }
        }

        private void Check()
        {
            Console.WriteLine("Checking for new something ELSE...");

            //Do Some sort of work here; just writing a random number to console
            Random rnd = new Random();
            Console.WriteLine(string.Format("{0} - {1}", this.LogObjectName, rnd.Next(1, 50)));


        }


    }
}
