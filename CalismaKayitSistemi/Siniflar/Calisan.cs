using System;

namespace CalismaKayitSistemi.Siniflar
{
    class Calisan : Kisi
    {
         private string _sgkNo; //prop bu

         //ctor
         public Calisan(string sgkNo,string tcNo,string adSoyad)
         : base(tcNo, adSoyad) //buraya base vermezsen calısan hata veriyor zaten.
         {
             _sgkNo = sgkNo;
         }
          public override void KendindenBahset()
        {
            Console.WriteLine($"{_tcNo} - {_adSoyad} - {_sgkNo}");

        }
         
    }

}