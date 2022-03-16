using System;
using System.Collections.Generic;
using System.Text;


namespace Kart
{
    class KartComparer : IComparer<Kart>
    {
         public SiraKriter SiralamaKriteri = SiraKriter.DegerTip;

        public int Compare(Kart x, Kart y)
        {
            if (SiralamaKriteri == SiraKriter.DegerTip)
                if (x.Deger > y.Deger)
                    return 1;
                else if (x.Deger < y.Deger)
                    return -1;
                else
                    if (x.Tip > y.Tip)
                    return 1;
                else if (x.Tip < y.Tip)
                    return -1;
                else
                    return 0;
            else
                if (x.Tip > y.Tip)
                return 1;
            else if (x.Tip < y.Tip)
                return -1;
            else
                if (x.Deger > y.Deger)
                return 1;
            else if (x.Deger < y.Deger)
                return -1;
            else
                return 0;
           
        }
    }
}
