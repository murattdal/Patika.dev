using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            Console.WriteLine("#############");

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            Console.WriteLine("#############");

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            Console.WriteLine("#############");

            LogManager logManager = new LogManager(new SmsLogger());
            logManager.WriteLog();

        }
    }
}
