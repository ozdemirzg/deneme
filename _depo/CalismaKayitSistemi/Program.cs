using System;
using System.Collections.Generic;
using CalismaKayitSistemi.Siniflar;

namespace CalismaKayitSistemi
{
    class Program
    {
        static List<Kisi> Kisiler = new List<Kisi>();

        static void Main(string[] args)
        {
            // Ogrenci kayıt yapılacak

            bool devam = true;

            while (devam)
            {
                // Girişler
                var girisiYapılanKisi = Giris();
                // Kayıt ekleme
                Kisiler.Add(girisiYapılanKisi);

                // Devam?
                devam = (Devam()) ? true : false;

                // if (Devam())
                // {
                //     devam = true;
                // }
            }


            // Ogrenci o = new Ogrenci("101", "12345", "Ali Keskin");
            // Calisan c = new Calisan("999999", "12345", "Veli Keskin");
            // Egitmen e = new Egitmen(EgitmenBolum.Matematik, "888888", "12345", "Hasan Keskin");

            // List<IkBahseden> topluluk = new List<IkBahseden>();
            // topluluk.Add(o);
            // topluluk.Add(c);
            // topluluk.Add(e);

            // foreach (var t in topluluk)
            // {
            //     t.KendindenBahset();
            // }

        }

        private static bool Devam()
        {
            Console.WriteLine("Devam için (a)");
            char devamGiris = Console.ReadKey().KeyChar;

            return (devamGiris == 'a') ? true : false;

            // if (devamGiris == 'a')
            //     return true;
            // else
            //     return false;
        }

        private static Kisi Giris()
        {
            char g = ' '; // seçim için değişken
            bool devam = true; // döngü bayrak;

            while (devam) // doğru giriş için 
            {
                Console.WriteLine("Seçim?");
                Console.WriteLine("(o) Öğrenci");
                Console.WriteLine("(e) Eğitmen");
                Console.WriteLine("(d) Destek Çalışanı");
                g = Console.ReadKey().KeyChar;

                if (g == 'e' || g == 'o' || g == 'd')
                {
                    devam = false;
                }
            }

            // ortak bilgileri al
            Console.Write("TC NO: ");
            string adGiris = Console.ReadLine();

            Console.Write("Ad: ");
            string tcNoGiris = Console.ReadLine();

            // Egitmen VEYA Destek elemanı bu değere atama yapıyor. 
            string sgkNoGiris = "girilmedi";

            string ogrenciNoGiris = "girilmedi";

            string egitmenBolumGiris = "girilmedi";
            EgitmenBolum egitmenBolumGirisEnum = EgitmenBolum.Fen; // sabitledik geçici çözüm

            string calisanBolumGiris = "girilmedi";
            CalisanBolumler calisanBolumGirisEnum = CalisanBolumler.Yemek; // sabitledik geçici çözüm

            switch (g)
            {
                case 'o':
                    //
                    Console.Write("Öğrenci NO: ");
                    ogrenciNoGiris = Console.ReadLine();
                    break;
                case 'e':
                    Console.Write("SGK NO: ");
                    sgkNoGiris = Console.ReadLine();
                    Console.Write("Ders Verdiği Bölum Adı: "); // Enum'a çevirme işi
                    egitmenBolumGiris = Console.ReadLine();
                    break;
                case 'd':
                    Console.Write("SGK NO: ");
                    sgkNoGiris = Console.ReadLine();
                    Console.Write("Ders Verdiği Bölum Adı: "); // Enum'a çevirme işi
                    calisanBolumGiris = Console.ReadLine();
                    break;
                default:
                    // 
                    break;
            }

            // 
            Ogrenci o;
            Egitmen e;
            Destek d;

            // k = null;

            switch (g)
            {
                case 'o':
                    o = new Ogrenci(ogrenciNoGiris, tcNoGiris, adGiris);
                    Kisi ko;
                    ko = o;
                    return ko;
                case 'e':
                    e = new Egitmen(egitmenBolumGirisEnum, sgkNoGiris, tcNoGiris, adGiris);
                    Kisi ke;
                    ke = e;
                    return ke;
                case 'd':
                    d = new Destek(calisanBolumGirisEnum, sgkNoGiris, tcNoGiris, adGiris);
                    Kisi kd;
                    kd = d;
                    return kd;
                default:
                    //
                    Kisi k;
                    k = null;
                    return k;
            }

            //                          
            // Ogrenci o = new Ogrenci("101", "12345", "Ali Keskin");
            // Calisan c = new Calisan("999999", "12345", "Veli Keskin");
            // Egitmen e = new Egitmen(EgitmenBolum.Matematik, "888888", "12345", "Hasan Keskin");


            // Ogrenci kayıt yapılacak
            // Ogrenci o = new Ogrenci("101", "12345", "Ali Keskin");

            // var k = new Kisi("12345", "Ali Keskin");
        }

        private static void Kayit()
        {

            // ? 

        }
    }
}
