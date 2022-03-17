using System;
using System.Collections.Generic;

namespace Kart
{
    class KartDeste
    {
        static Tip RastgeleTip()
        {
            Random r = new Random();
            return (Tip)r.Next(0, 4);
        }
        static Deger RastgeleDeger()
        {
            Random r = new Random();
            return (Deger)r.Next(0, 13);
        }
        static void Main(string[] args)
        {
            List<Kart> kartlar = new List<Kart>();
            for (int i = 0; i < 12; i++)
            {
                kartlar.Add(new Kart() { Tip = RastgeleTip(), Deger = RastgeleDeger() });
            }
            foreach (var i in kartlar)
            {
                Console.WriteLine("tip:" + i.Tip + "    deger:" + i.Deger);
            }
            KartComparer comparer = new KartComparer();
            System.Console.WriteLine("\n önce değer sonra tipe göre sıralama\n");
            comparer.SiralamaKriteri = SiraKriter.DegerTip;
            kartlar.Sort(comparer);

            foreach (var i in kartlar)
            {
                System.Console.WriteLine("tip:" + i.Tip + "    deger:" + i.Deger);
            }





        }
    }
}
