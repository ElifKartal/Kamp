using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Elif", "Mesut", "Hatice", "Aybüke" };// isimler dizisi genişletilemez 4 elemanlı dizi 5 elemanlıya çevirilemez,

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // burada yeni bir string listesi oluştu eski liste kayboldu, yeni adreste ilk 4 veri olmaz. görünmez,
            //isimler[4] = "Mert";  // listenin souna yazılmış gibi görünsede aslında yeni bir adreste ilk dört elemanı boş olan bir liste tanımlamış olduk 
            //Console.WriteLine(isimler[4]);//her new kelimesinde yeni bir adrese geçer.
            //Console.WriteLine(isimler[0]);
            
            
            //<>  generic yapı
            List<string> isimler2 = new List<string>() { "Elif", "Mesut", "Hatice", "Aybüke" };//string listesi
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Mert");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);//listelerin sonuna yeni eleman eklenebilir.
            




        }
    }
}
