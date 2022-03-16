using System;
using System.Collections.Generic;

namespace Kart
{
    class KartComparerByDeger : IComparer<Kart>
    {
        public int Compare(Kart x, Kart y)
        {
            if (x.Deger < y.Deger)
                return -1;
            if (x.Deger > y.Deger)
                return 1;
            return 0;
            

        }
    }
}
