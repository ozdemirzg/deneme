using System;
namespace KisiNakit
{
    class Kisi
    {
        public string Ad { get; set; }
        public int Nakit { get; set; }

        public Kisi(string ad, int nakit)
        {
            Ad = ad;
            Nakit = nakit;
        }

        public void NakitAl(int miktar)
        {
            Nakit += miktar;

        }
        public int NakitVer(int miktar)
        {
            if (miktar > Nakit)
            {
                System.Console.WriteLine("Param yok..");
                return 0;
            }
            else
            {
                Nakit -= miktar;
                return miktar;
            }

        }
        public void BilgileriYaz()
        {
            Console.WriteLine($"Adım {Ad}, nakit {Nakit}");
        }

    }

}