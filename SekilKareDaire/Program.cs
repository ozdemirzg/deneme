/*
Şekil, Kare ve Daire sınıfları yazılacak
Kare ve Daire, Sekil sınıfından türeyecek

Kare, bir kenar uzunluğu ile oluşturulacak
Daire, yariçap uzunluğu ile oluşturulacak

Sekil sınıfında, herhangi iki şekli birleştirebilen bir metot tanımlanacak.
Birleştirme işlemi, birleştirilen şekillerin alanlarının toplamının hesaplanması demek.

Aşağıdaki "Main" metotta kullanım şekli gösterilmiştir.
"Main" içine herhangi bir kod eklemesi yapılmayacak.
"Birlestir" metotu Sekil sınıfı üzerinden gerçekleştirilecek.

Bu çalışmayı sağlayan sınıfları yazınız.

Not: tüm işlemleri int tipinde yapınız. Pi sayısını 3 olarak kullanınız.
 */

using System;
using System.Collections.Generic;

namespace Odev.SekilKareDaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int birlesmisAlan;

            var d = new Daire(3);       // yarıçap 3 alan 27
            var k = new Kare(5);        // kenar 5 alan 25

            birlesmisAlan = Sekil.Birlestir(d, k);
            Console.WriteLine(birlesmisAlan);       // çıkış : 52

            birlesmisAlan = Sekil.Birlestir(d, d);
            Console.WriteLine(birlesmisAlan);       // çıkış : 54

            birlesmisAlan = Sekil.Birlestir(k, k);
            Console.WriteLine(birlesmisAlan);       // çıkış : 50

        }
    }

    class Sekil
    {
        public static int Birlestir(Daire d, Kare k) { return d.Alan + k.Alan; }
        public static int Birlestir(Daire d, Daire dd) { return d.Alan + dd.Alan; }
        public static int Birlestir(Kare k, Kare kk) { return k.Alan + kk.Alan; }
        public static int Birlestir(Kare k, Daire d) { return d.Alan + k.Alan; }

    }

    class Kare : Sekil
    {
        private int _k;
        public int Alan { get; set; }
        public Kare(int k)
        {
            _k = k;
            Alan = k * k;
        }


    }

    class Daire : Sekil
    {
        public int Alan { get; private set; }
        private int _yc;
        public Daire(int yc)
        {
            Alan = yc * yc * 3;
            _yc = yc;
        }


    }

}
