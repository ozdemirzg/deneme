using System;
using CalismaKayitSistemi.Siniflar;

namespace CalismaKayitSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;
            while(true)
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

            Ogrenci o = new Ogrenci(No ="2555"); //o.diye değilde bu şekilde tanımlanması lazım.Bununda çalışması için ctor tanımlaman lazım.
             
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
