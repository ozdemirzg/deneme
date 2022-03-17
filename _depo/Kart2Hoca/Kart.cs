using System;

namespace OyunKartSiralama
{
    class Kart : IComparable<Kart>
    {
        public KartTip Tip { get; set; }
        public KartDeger Deger { get; set; }

        public Kart(KartTip tip, KartDeger deger)
        {
            Tip = tip;
            Deger = deger;

        }

        public int CompareTo(Kart diger)
        {
            if (Tip > diger.Tip)
                return -1;

            if (Tip < diger.Tip)
                return 1;

            if (Tip == diger.Tip) // tipler eşit degere bakılmalı
            {
                if (Deger > diger.Deger)
                    return -1;

                if (Deger < diger.Deger)
                    return 1;
            }
            return 0; // tip ve deger eşit 
        }
        public override string ToString()
        {
            return $"KART : {Tip} | {Deger}";
        }
    }
}