using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventWorkerExample.Infrastructure;

namespace EventWorkerExample.Transactions {
    public sealed class TestTransaction : XMLTransactionMessageBase<TestTransaction> {

        public int ID { get; set; }
        public string Message { get; set; }

        private TestTransaction() {

        }
    }
}
