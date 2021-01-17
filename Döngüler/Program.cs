using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den 10 a kadar olan sayıları yazırdı.
            {

                string kurs1 = "yazılım geliştirici";
                string kurs2 = " programlamaya başlama";
                string kurs3 = "java";
                //array * dizi
                string[] kurslar = new string[] { "yazılım geliştirici", "programlamaya başlama", "java", "Python", "C#", "C++", "C" };

                for (int i = 0; i < kurslar.Length; i++)//kurslar.Lenght kursların uzunluğundaki bütn elemanları yazıyor.
                {
                    Console.WriteLine(kurslar[i]);
                }
                Console.WriteLine("for bitti");
                foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }


                Console.WriteLine("sayfa sonu-footer");
            }

        }
    }
}
