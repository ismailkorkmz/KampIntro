using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming Convetion
        // sytax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendisdfs : "+ urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int Stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
