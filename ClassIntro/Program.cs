using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] kurslar = new string[] { "a", "b", "c" };

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlemmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Yarış";
            kurs2.IzlemmeOrani = 74;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlemmeOrani = 81;

            //Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (Kurs item in kurslar)
            {
                Console.WriteLine(item.KursAdi);
                Console.WriteLine(item.IzlemmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemmeOrani { get; set; }

        

    }


}
