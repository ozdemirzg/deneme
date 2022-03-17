using System;

namespace Banka
{
    class VadeliHesap : BankaHesabi
    {
        public VadeliHesap(string ad, decimal acilisBakiye) : base (ad,acilisBakiye)
        {
            //kendi ctor um buraya.
            
        }
        public override void AySonuIslem()
        {
            decimal faiz = Bakiye * 0.02m;
            ParaYatir(faiz,"aylık faiz");
        }
        
    }
}