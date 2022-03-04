using System;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Giriş yapınız.(Çıkmak için ENTER'a basınız..)"   );
            string giris;
            Sayi sayi = new Sayi();
            Metin metin = new Metin();
            
            List<string> girisler =new List<string>();
            
            do
            {
                giris = Console.ReadLine();
                
             
                girisler.Add(giris);

            
                if (int.TryParse(giris,out int sayiGiris))
                {
                  sayi.sayilarEkle(sayiGiris);
                }
                else
                {
                  Metin.metinEkle(giris);
                }
                
            } while (giris !="");
             
             void GirisListe()
             {
                foreach (var g in girisler)
                {
                    System.Console.WriteLine(g);
                }
             }
            

            string secenek;
         
            System.Console.WriteLine("(a) girişlerimdeki tek sayıları listele");
            System.Console.WriteLine("(b) girişlerimdeki çift sayıları listele");
            System.Console.WriteLine("(c) girişlerimdeki metinlerde kullanılan toplam sesli harf sayısı?");
            System.Console.WriteLine("(d) girişlerimdeki metinlerde kullanılan toplam sessiz harf sayısı?");
            System.Console.WriteLine("(e) girişlerimdeki sayıları listele");
            System.Console.WriteLine("(f) girişlerimdeki metinleri listele");
            System.Console.WriteLine("(g) tüm girişlerimi listele");
            Console.Write("Giriş yapınız: " );

            secenek=Console.ReadLine();

            switch (secenek)
            {
                case "a": 
                sayi.TekSayilarListe();
                break;

                case "b":
                sayi.CiftSayilarListe();
                break;

                case "c":
                Metin.SesliTotal();
                break;
                
                case "d":
                Metin.SessizTotal();
                break;

                case "e":
                sayi.sayilarListe();
                break;

                case "f":
                Metin.MetinListe();
                break;

                case "g":
                GirisListe();
                break;
                 
                default:Console.WriteLine("Yanlış giriş yatınız! ");break;
            }
        }
       
    }
}
