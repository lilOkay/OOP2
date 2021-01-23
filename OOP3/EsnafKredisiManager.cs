using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager : ICrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {//mesela ben esnaf kredisini sonradan ekledim ama hiç zorlanmadan
            Console.WriteLine("esnaf kredisi hesaplandı!");
        }
    }
}
