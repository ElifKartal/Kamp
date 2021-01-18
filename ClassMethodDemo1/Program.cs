using System;

namespace ClassMethodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Kartal";
            musteri1.Tc = 12345678901;
            musteri1.Id = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mesut";
            musteri2.Soyadi = "Kartal";
            musteri2.Tc = 09876543210;
            musteri2.Id = 67890;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Hatice";
            musteri3.Soyadi = "Kartal";
            musteri3.Tc = 23457890156;
            musteri3.Id = 13579;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-----------------Müsteri ekle-----------------");
            foreach (var musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("---------Musterileri Listele--------------");
            Console.WriteLine("Müşteriler:");
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }

            Console.WriteLine("-----------Musteri sil----------------");

            foreach (var musteri in musteriler)
            {
                musteriManager.Sil(musteri);
                Console.WriteLine("-------------------------------");
            }




        }
    }
}
