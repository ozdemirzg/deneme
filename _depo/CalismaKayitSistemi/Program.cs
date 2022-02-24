using System;
using CalismaKayitSistemi.Siniflar;

namespace CalismaKayitSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            
             // Ogrenci kayıt yapılacak
            Ogrenci o = new Ogrenci("101", "12345", "Ali Keskin");
            Calisan c = new Calisan("999999", "12345", "Veli Keskin");
            Egitmen e = new Egitmen(EgitmenBolum.Matematik, "888888", "12345", "Hasan Keskin");
           
            //o.Bolum = "Matematik";
           var t =new Test();
           System.Console.WriteLine(t);
        //    string ts = t.ToString();


            bool devam = false;
            while(devam)
            {
            // Girişler
                Giris();

            // Kayıt Yapılması
                Kayit();
                
            //Devam?
              if (Devam())
              {
                  devam=true;
              }    
            }
           
        }

        private static bool Devam()
        {
            throw new NotImplementedException();
        }

        private static void Giris()
        {
            // Sorduk
            // Ogrenci kayıt yapılacak

            Ogrenci o = new Ogrenci("101", "12345", "Ali Keskin");
       //o.diye değilde bu şekilde tanımlanması lazım.Bununda çalışması için ctor tanımlaman lazım.
             

             //var k = new Kisi ("12345", "Ali Keskin");


            // o.TcNo ="234567789";
            // o.AdSoyad = "Ali Coşar";
            // o.No = "10001";

            /* Kisi k = new Kisi();
            k.AdSoyad = "das"; // ? Bunun olmaması lazım.kişi mi girmek istiyorsun demeyeceğiz çünkü.öğrenci eğitimci ya da calısan mı girmek istiyorsun diyeceğiz.
            Biz hiçbir zaman kişi üretmeyeceğiz burada.erişimi engellemeliyiz. */

        }

        private static void Kayit()
        {
           



        }
    }
}
