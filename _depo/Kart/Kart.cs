using System;
using System.Collections.Generic;

namespace Kart
{
    class Kart : IComparable<Kart>
    {
     public Tip Tip { get; set; }
     public Deger Deger { get; set; }

    //    public Kart(Tip tip, Deger deger)
    //    {
    //        Deger=deger;
    //        Tip=tip;
    //    }
        public int CompareTo(Kart KartKiyaslama)
        {
            if (this.Deger > KartKiyaslama.Deger)
                return 1;
            else if (this.Deger < KartKiyaslama.Deger)
                return -1;
            else
                return 0;
        }
    }
}
