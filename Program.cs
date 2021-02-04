using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
           


            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager };


            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
