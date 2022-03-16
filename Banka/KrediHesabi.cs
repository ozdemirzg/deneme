using System;

namespace Banka
{
    class KrediHesabi : BankaHesabi
    {

        public KrediHesabi(string ad, decimal acilisBakiye) : base (ad,acilisBakiye)
        {
            //kendi ctor um buraya. 
        }

         public override void AySonuIslem()
        {
           if (Bakiye < 0)
            {
                decimal faiz = -Bakiye * 0.02m;
                ParaCek(faiz, "kredi kullanım faiz");
            }

        }
    }
}