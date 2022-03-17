using System;
using System.Collections.Generic;

namespace OyunKartSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek grup oluştur (10)
            List<Kart> kartlar = OrnekGrupOlustur(10);

            // yazdır
            KartlarYazdir(kartlar);
            System.Console.WriteLine("Sıralı");

            // Sırala
            // kartlar.Sort();
            var kartComparer = new KartComparer();
            // Yazdır
            KartlarYazdir(kartlar);
        }

        private static void KartlarYazdir(List<Kart> karts)
        {
            foreach (var k in karts)
            {
                Console.WriteLine(k);
            }
        }

        private static List<Kart> OrnekGrupOlustur(int kapasite)
        {
            var r = new Random();

            List<Kart> kartlar = new List<Kart>();

            for (int i = 0; i < kapasite; i++)
            {
                KartTip tip = (KartTip)r.Next(4);
                KartDeger deger = (KartDeger)r.Next(2, 15);
                kartlar.Add(new Kart(tip, deger));
            }
            return kartlar;
        }
    }
}
