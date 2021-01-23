using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo ="12345";
            musteri1.Adi = "engin";
            musteri1.SoyAdi = "demiroğ";
            musteri1.TcNo = "2222222222";
            musteri1.Id = 1;

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";

            //ama şirket adı enginle alakalı değildir
            //gerçek Müşteri-tüzel Müşteri (bunlar birbirinin yerine asla kullanılamazlar)ikiside ayrı şeylerdirler
            //SOLID 

            Musteri musteri3 = new GercekMusteri();//bizim müsterimiz hgem gerçeği hem tüzeli tutabiliyor çünkü miraslı
            Musteri musteri4 = new TuzelMusteri();//Musteri  hem gerçekğin hemde tüzelin referansını tutabiliyor

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);//fark ettiyseniz burada hem musteri 1 hem 2 hem 3 hem de 4 ü yollayabildik
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
