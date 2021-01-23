using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{//coorporate
    class TuzelMusteri:Musteri //miras inheritance //tüzel müşteri bir müşteridir demek oluyor
        //musteride olan bilgiler artık burada da vardır
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
