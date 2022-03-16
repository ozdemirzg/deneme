using System;

namespace Banka
{
    class HediyeCuzdan : BankaHesabi
    {
        private readonly decimal _sabitYukleme = 0m;
       
        public HediyeCuzdan(string ad, decimal acilisBakiye,decimal sabitYukleme) : base (ad,acilisBakiye)
        {
            //kendi ctor um buraya.
            _sabitYukleme = sabitYukleme;     
        }
         public override void AySonuIslem()
        {
            if (Bakiye == 0)
            {
                ParaYatir(_sabitYukleme, "Sabit aylık yükleme");
            }
        }
        
    }
}