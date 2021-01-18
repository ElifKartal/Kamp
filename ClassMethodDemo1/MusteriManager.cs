using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi!");
            Console.WriteLine("Musteri Adı : " + musteri.Adi);
            Console.WriteLine("Musteri Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Musteri Tc : " + musteri.Tc);
            Console.WriteLine("Musteri Id : " + musteri.Id);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silindi!");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
        }
    }
}
