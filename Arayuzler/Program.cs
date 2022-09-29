using System;

namespace Arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();


            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();


            SmsLogger smsLogger = new(); // Bu new'leme işlemi yukarıdakiler ile aynı
            smsLogger.WriteLog();


            LogManager logManager = new LogManager(new FileLogger()); // logManeger ne yolladığımı bilmiyor, ne gönderirsem onu yazacak.
            logManager.WriteLog();
        }
    }
}
