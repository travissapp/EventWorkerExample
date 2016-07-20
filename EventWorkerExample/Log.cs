using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventWorkerExample
{
    public static class Log
    {
       

        /// <summary>
        /// Log message 
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="logObjectName">The name of the object being logged. For messages use the message class name.</param>
        public static void WriteAndLog(string message, string logObjectName)
        {
            //TODO: IMPLEMENT LOGGING
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
