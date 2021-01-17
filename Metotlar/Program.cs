using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açıklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açıklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe --- tip güvenli

            foreach (Urun Urun in urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine(Urun.Açıklama);
                Console.WriteLine("-----------------");


                Console.WriteLine("-----------Metotlar---------------");

                // instance - örnek
                // encapsulation
                SepetManager sepetManager = new SepetManager();

                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);

                sepetManager.Ekle2("Armut","Yeşil Armut",12,10);
                sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
                sepetManager.Ekle2("Karpuz", "Diryarbakır Karpuzu", 12,8);


            }

        }
    }
}
