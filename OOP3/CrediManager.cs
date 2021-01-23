using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICrediManager//başıuna I koymamızın nedeni interface olduğunu anlmamızı sağlar
    {//bu sadece base ebebeyn görevini görür tek başına bi anlamı yok
        //interface olduğu için bu alttakileri yapmak zorundadır mutlaka //interface kuralları içerir

            void Hesapla();

            void BirseyYap();

        //eğer birisi bu interfaceyi kullanırsa o arkadaş şu methodu içermek zorunda
    }
}
