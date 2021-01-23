using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionaryList<T1,T2,T3>
    {
        T1[] Tc;
        T2[] isimler;
        T3[] Kurslar;
        public MyDictionaryList()
        {
            Tc = new T1[0];
            isimler = new T2[0];
            Kurslar = new T3[0];

        }
        public void Add(T1 Tcno, T2 isim, T3 Kurs)
        {
            T1[] tempArray = Tc;
            T2[] tempArray2 = isimler;
            T3[] tempArray3 = Kurslar;
            Tc = new T1[Tc.Length + 1];
            isimler = new T2[isimler.Length + 1];
            Kurslar = new T3[Kurslar.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Tc[i] = tempArray[i];
                isimler[i] = tempArray2[i];
                Kurslar[i] = tempArray3[i];
            }
            Tc[Tc.Length - 1] = Tcno;
            isimler[isimler.Length - 1] = isim;
            Kurslar[Kurslar.Length - 1] = Kurs;

        }

        public int Lenght()
        { return Kurslar.Length; }
       
        public T1[] Tcno
        {
            get { return Tc; }
        }
        public T2[] isim
        {
            get { return isimler ; }
        }
        public T3[] Kurs
        {
            get { return Kurslar; }
        }
    }
}
