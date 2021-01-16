using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun item)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + item.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)
        //public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }

    }
}
