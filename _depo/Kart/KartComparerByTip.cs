using System;
using System.Collections.Generic;

namespace Kart
{
    class KartComparerByTip : IComparer<Kart>
    {
        public int Compare(Kart x, Kart y)
        {
            if (x.Tip < y.Tip)
                return -1;
            if (x.Tip > y.Tip)
                return 1;
            else
                return 0;

        }
    }
}
