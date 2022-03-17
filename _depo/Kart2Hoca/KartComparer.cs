using System.Collections;
using System.Collections.Generic;

namespace OyunKartSiralama
{
    class KartExtra : IComparer<Kart>
    {
        public int Compare(Kart x, Kart y)
        {
            return x.CompareTo(y);
        }
    }

}