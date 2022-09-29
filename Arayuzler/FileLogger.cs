using System;

namespace Arayuzler
{
    class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya Yazar...");
        }
    }
}