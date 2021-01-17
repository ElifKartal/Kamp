using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety * tip güvenliği
            // do not repeat yourself * kendini tekrarlama
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmısMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)

            {
                Console.WriteLine("azalış oku");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }


            if (sistemeGirişYapmısMi == true)

            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");

            }


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(ogrenciSayisi);

        }
    }
}
