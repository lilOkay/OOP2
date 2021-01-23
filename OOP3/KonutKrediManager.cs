using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //ICrediManager referans tutar
    class KonutKrediManager : ICrediManager//ımplemen inteface yap (ampule tıklayarak)//bu sayede herkes artık kendi lurallarını yazabilir
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı!");
        }
    }
}
