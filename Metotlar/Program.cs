using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)

        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe (tip güvenli)
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("----------Metotlar---------");
            //instance - örnek
            //encapsulation

            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetmanager.Ekle2("Elma", "Yeşil elma", 15, 20);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80, 130);

        }
    }
}





//Don't repeat yourself (DRY)  
//Clean Code
//Best Practice (doğru/en iyi uygulama teknikleri)