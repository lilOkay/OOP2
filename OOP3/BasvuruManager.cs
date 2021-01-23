using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        //method injection
        public void BasvuruYap(ICrediManager crediManager,ILoggerService loggerService)//hangi krediyi girersen ona göre yönlendirir çünkü bu refaran büyün credileri içinde tutuyor
        {
            //başvuran bilgilerini değerlendirme

            crediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler)//bana bir liste ver ama o listenin tütü ICrediManager olsun demek
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
