using System;

namespace Business.CrossCuttingConcerns
{
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
