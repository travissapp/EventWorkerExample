using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EventWorkerExample.Infrastructure;

namespace EventWorkerExample
{
    public class TestDataChecker : CheckerBase
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
            get { return 1000; }
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
            Console.WriteLine("Checking for test data...");

            //Would query here from some message query; Azure/MSMQ/etc... pull one from mock data
            var query = TestTransactionData.Instance.Data.Where(x => x.IsProcessed == false).FirstOrDefault();

            if(query!= null) {

                //DeSerialize XML to obj
                var trans = EventWorkerExample.Transactions.TestTransaction.CreateInstance(query.Message);
                //Do work based on the message object type
                Console.WriteLine(string.Format("{0} - {1}", this.LogObjectName, trans.Message));
                
                //set data to processed
                query.IsProcessed = true;
            }

            

        }      
        

    }
}
