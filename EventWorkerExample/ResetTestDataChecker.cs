using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EventWorkerExample
{
    public class ResetTestDataChecker : CheckerBase
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
            get { return 35000; }
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
            Console.WriteLine("Checking for to see if all TestData has been completed...");

            
            var query = TestTransactionData.Instance.Data.Where(x => x.IsProcessed == false).Count();

            if(query == 0) {
                //reset all data

                TestTransactionData.Instance.Data.ForEach(x => {
                    x.IsProcessed = false;
                    Console.WriteLine(string.Format("{0} - {1} set to unprocessed.", this.LogObjectName, x.ID));
                });
                Console.WriteLine("All data reset to unprocessed.");

            } else {
                Console.WriteLine("All TestData not yet processed.");
            }

          
            


        }


    }
}
