using System;
using System.Collections.Generic;

namespace Odev1
{
    class Sayi
    {

        List<int> sayilar = new List<int>();
        List<int> sayilarCift = new List<int>();
        List<int> sayilarTek = new List<int>();


      
        public void sayilarEkle(int sayi)
        {
            sayilar.Add(sayi);
        }

        public void sayilarListe()
        {
            foreach (var s in sayilar)
            {
                Console.WriteLine(s);
            }
        }

        public void sayiCiftTek(int sayi)
        {
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayi % 2 == 0)
                {
                    sayilarCift.Add(sayi);
                }
                else
                {
                    sayilarTek.Add(sayi);
                }

            }
        }
        public void TekSayilarListe()
        {
            foreach (var s in sayilarTek)
            {
                Console.WriteLine(s);
            }

        }
        public void CiftSayilarListe()
        {
            foreach (var s in sayilarCift)
            {
                Console.WriteLine(s);
            }

        }



    }
}
