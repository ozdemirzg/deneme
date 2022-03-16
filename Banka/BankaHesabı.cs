using System;
using System.Collections.Generic;

namespace Banka
{
    class BankaHesabi
    {
        private static int no = 1234567890;
        public string HesapNo { get; private set; }
        public string HesapAd { get; set; }
        public decimal Bakiye { get; set; }

        private List<Islem> Islemler=new List<Islem>(); // new li kısmı buraya yazmasaydın bütün ctorlara eklmemn lazımdı.



        private void HesapNoAtama()
        {
            HesapNo = no.ToString();
            no++;
        }
        #region BankaHesabı


        public BankaHesabi(string ad)
        {
            HesapAd = ad;
            HesapNoAtama();
            ParaYatir(0, "Açılış");
        }

        public BankaHesabi(string ad, decimal bakiye)
        {
            
            HesapAd = ad;
            HesapNoAtama();

            //Bakiye = bakiye;    // Bunu kullanacağın zaman private set yapman lazımdı.yapmadı. o yüzden değiştirdi.object tanımladı.
            ParaYatir(bakiye,"Açılış");
        }
        #endregion
        #region ParaYatirCek

        public void ParaYatir(decimal miktar, DateTime tarih, string not)
        {
            var i = new Islem(miktar, tarih, not);

            Bakiye += i.Miktar;
            Islemler.Add(i);
        }

        public void ParaYatir(decimal miktar, DateTime tarih)
        {
            var i = new Islem(miktar, tarih);
            Bakiye += i.Miktar;
            Islemler.Add(i);
        }

        public void ParaYatir(decimal miktar)
        {
            var i = new Islem(miktar);
            Bakiye += i.Miktar;
            Islemler.Add(i);
        }
          public void ParaYatir(decimal miktar, string not)
        {
            var i = new Islem(miktar, DateTime.Now, not);
            Bakiye += i.Miktar;
            Islemler.Add(i);

        }
    

        public void ParaCek(decimal miktar, DateTime tarih, string not)
        {
            var i = new Islem(miktar, tarih, not);
            Bakiye -= i.Miktar;
            Islemler.Add(i);
        }
        public void ParaCek(decimal miktar, DateTime tarih)
        {
            var i = new Islem(miktar, tarih);
            Bakiye += i.Miktar;
            Islemler.Add(i);
        }

        public void ParaCek(decimal miktar)
        {
            var i = new Islem(miktar);
            Bakiye += i.Miktar;
            Islemler.Add(i);
        }

           public void ParaCek(decimal miktar, string not)
        {
            var i = new Islem(miktar, not);
            Bakiye -= i.Miktar;
            Islemler.Add(i);

        }
        #endregion


        public void IslemGecmisi()
        {
            foreach (var i in Islemler)
            {
               Console.WriteLine($"{HesapAd} : {i.Tarih} : {i.Miktar} - {i.Not}");
            }
        }


       public virtual void AySonuIslem() { }
    }
}
