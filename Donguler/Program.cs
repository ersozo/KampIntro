using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici kampı", 
                                              "programlamaya başlangıç için temel kurs",
                                              "Java", "Python", "C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("--------------------------------");

            foreach (string item in kurslar)
            {
                Console.WriteLine(item);
            }
             // item - alias


        }
    }
}
