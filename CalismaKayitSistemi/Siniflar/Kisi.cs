using System;
namespace CalismaKayitSistemi.Siniflar
{
    enum CalisanBolumler
    {
        Yemek,
        Temizlik,
        İdari
    }
     enum EgitmenBolum
    {
        Fen,
        Matematik,
        Sosyal
    }

    abstract class Kisi 
    {
        // public static string kurumAd;

        //propların get set ini silip _ile yazdık isimleri.
        protected string _tcNo; //Bunlara Mainde atama yapmayı engellemek için protected yaptık.
        protected string _adSoyad;

        //constructor ile :base olarak yazdığımızı çalıştırmayı sağladı bu kısım.
        public Kisi(string tcNo, string adSoyad)
        {
            _tcNo = tcNo;
            _adSoyad = adSoyad;
        }
        public abstract void KendindenBahset();
       
    }

}