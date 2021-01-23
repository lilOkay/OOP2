using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {//birbirinni alternetifi olan ama kodları birbirinden farklı olduğu zaman interface kullanırız
        static void Main(string[] args)
            //interfacelerde referans numarası tutabilir yani ICrediManagerda yazabiliriz başa
        {
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICrediManager tasitKrediManager = new TasitKrediManager();
            ICrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,new DatabaseLoggerService());//buraya tasıtKrediManager koysaydın onu hesaplardı:) bizi işe sokabilecek bir bilgi:))

            List<ICrediManager> krediler = new List<ICrediManager>() {ihtiyacKrediManager,tasitKrediManager };//listenin içine 3tanede debir tande kredi yükleyebilirsiniz

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
