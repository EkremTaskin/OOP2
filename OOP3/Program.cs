using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // interfaceler inherit edildiği classların referansını tutabiliyor 
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            List<IKrediManager> krediManagers = new List<IKrediManager> { new IhtiyacKrediManager(), new TasitKrediManager(), new KonutKrediManager() };

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> { new DatabaseLoggerService() , new FileLoggerService(),
                 new SmsLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(krediManagers , loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            Console.ReadLine();
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
