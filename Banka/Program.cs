using System;
using System.Collections.Generic;

namespace Banka
{
    class BankaHesabi
    {
        private static int no = 1234567890;
        public string HesapNo { get;set }
        public string HesapAd { get; set; }
        public double Bakiye { get;set;}

        private List<Islem> Islemler;

            private void HesapNoAtama()
        {
            HesapNo = no.ToString();
            no++;
        }


         public BankaHesabi(string ad)
        {
            HesapAd = ad;

            HesapNoAtama();
        }

        public BankaHesabi(string ad, int bakiye)
        {
            HesapAd = ad;
            Bakiye = bakiye;

            HesapNoAtama();
        }
      

        public void ParaYatir(Islem i)
        {
           Bakiye += i.Miktar;
           Islemler.Add(i);
            
        }

        public void ParaCek(Islem i)
        {
          Bakiye -= i.Miktar;
          Islemler.Add(i);
        }

        public  void IslemGecmisi()
        {
          foreach (var i in Islemler)
            {
                Console.WriteLine($"{i.Tarih} - {i.Tip} : {i.Miktar} - {i.Not}");
            }

        }

        

    }

    class Islem
    {
        public int Miktar { get; private set; }
        public DateTime Tarih { get; private set; }  
        public string Not { get; set; }
        public string Tip { get; set; }


        public Islem (int miktar,DateTime tarih, string not)
        {
            Miktar=miktar;
            Tarih=tarih;
            Not=not;
        }
     
        
        

    }
}
