using System;
using System.Collections.Generic;

namespace ZarOyunu
{
    class Program
    {
        static Dictionary<string, string> Oduller = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            int sonuc = Oyna();
            PuanDegerlendir(sonuc);
            //Final();
        }

        private static void Final()
        {
            throw new NotImplementedException();
        }


        private static int Oyna()
        {
            // Zarları oluştur
            var z1 = new Zar();
            var z2 = new Zar();
            var z3 = new Zar();

            // Zarlar atılıyor
            z1.At();
            z2.At();
            z3.At();

            Console.WriteLine("Zar1:" + z1.Deger + "\nZar2:" + z2.Deger + "\nZar3:" + z3.Deger);

            int toplam = z1.Deger + z2.Deger + z3.Deger;
            int ekstra = 0; // algoritma
            if (z1.Deger == z2.Deger && z2.Deger == z3.Deger)
            {
                ekstra = 6;
            }
            else if (z1.Deger == z2.Deger || z2.Deger == z3.Deger || z1.Deger == z3.Deger)
            {
                ekstra = 2;
            }

            int puan = toplam + ekstra;
            return puan;
        }
        private static void PuanDegerlendir(int p)
        {
            OdullerOlustur();

            if (p >= 16)
            {
                // Kazanma koşulu
                Console.WriteLine("Puanın:" + p + Oduller["araba"]);
            }
            else if (p >= 12)
            {
                // Kazanma koşulu
                Console.WriteLine("Puanın:" + p + Oduller["bilgisayar"]);
            }
            else if (p >= 7)
            {
                // Kazanma koşulu
                Console.WriteLine("Puanın:" + p + Oduller["seyahat"]);
            }
            else
            {
                // Kaybetme
                Console.WriteLine("Puanın:" + p + Oduller["su"]);
            }
        }

        private static void OdullerOlustur()
        {
            Oduller.Add("araba", "Araba Kazandın!");
            Oduller.Add("bilgisayar", "Bilgisayar Kazandın!");
            Oduller.Add("seyahat", "Seyahat Kazandın!");
            Oduller.Add("su", "Bir bardak su kazandın! Afiyet olsun:)");
        }
    }
}