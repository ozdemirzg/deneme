using System;
using System.Collections.Generic;

namespace Usem.Oyunlar
{
    class Program
    {
        static private int toplamPuan;   //bu classın hepsine aitti.Mehhod içinde yazılandan farkı bu.
        static private int kazanmaSinirPuan = 15;
        static private int atisSayisi = 3 ; // değiştirirsen ekstra değerlendirmeyi değiştir

        static void Main(string[] args)
        {
            Oyna();
            //Degerlendir();
            Final();
        }

        private static void Oyna()
        {
            Random zar = new Random();
            List<int> atislar = new List<int>();
            
            int atis;
            for (int i = 0; i < atisSayisi; i++)
            {
              atis = zar.Next(1, 7);
              atislar.Add(atis);
              System.Console.Write($" | {i + 1}.Atış : {atis} ");  
            }
              System.Console.WriteLine( );  
            
           /*  // Zarlar atılıyor
            int atis1 = zar.Next(1, 7);
            int atis2 = zar.Next(1, 7);
            int atis3 = zar.Next(1, 7); 
            Bu kısmı üst kısımda düzenledi.
            */
            int toplam = 0;
            foreach (var a in atislar)
            {
                toplam += a;
            }

            int ekstra = EkstraDegerlendir (atislar);
            toplamPuan = toplam + ekstra;
            Console.WriteLine("Puan : " + toplamPuan);
            
        }
        private static void Final()
        {
            if (toplamPuan > kazanmaSinirPuan)
            {
                // Kazanma koşulu
                Console.WriteLine("Kazandın");
            }
            else
            {
                // Kaybettin...
                Console.WriteLine("Kaybettin...");

            }
        }
        private static int EkstraDegerlendir(List<int> atisListe)
        {
           int z2 = atisListe[1];
           int z1 = atisListe[0];
           int z3 = atisListe[2];

           int ekstraPuan = 0;
        // algoritma gelecek 

            // iki zar aynı

            // üç zar aynı
             if (z1 == z2 && z2 == z3 ) 
            {
               ekstraPuan +=6;
                // 3 aynı var
            } 
            else if (z1 == z2 || z1 == z3 || z2 == z3) 
            {
                // 2 aynı var
                ekstraPuan +=2;
            } 
            else
            {
                Console.WriteLine("Ekstra puan yok");
                // yok
            }
            return ekstraPuan;



        } 

    }
}