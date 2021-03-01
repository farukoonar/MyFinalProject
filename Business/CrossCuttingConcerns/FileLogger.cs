using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CrossCuttingConcerns
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
