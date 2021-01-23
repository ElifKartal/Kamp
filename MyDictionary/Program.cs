using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<double, string, string> kursiyer = new MyDictionaryList<double, string, string>();
            kursiyer.Add(12345678901, "Elif", "C#");
            kursiyer.Add(65432112323, "Mesut", "C++");
            kursiyer.Add(78945612346, "Zehra", "Python");
            kursiyer.Add(34534578906, "Hatice", "C");

           

            Console.WriteLine("---Kursiyer Tc ---");
            foreach (var Tcno in kursiyer.Tcno)
            {
                Console.WriteLine(Tcno);
            }
            Console.WriteLine("-----Kursiyer İsim----");
            foreach (var isimler in kursiyer.isim)
            {
                Console.WriteLine(isimler);
            }
            Console.WriteLine("----Katıldığı Kurs-----");
            foreach (var Kurslar in kursiyer.Kurs)
            {
                Console.WriteLine(Kurslar);
            }
        }
    }
}
