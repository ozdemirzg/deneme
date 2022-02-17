using System;
using System.Collections.Generic;

namespace UsemKutuphane
{static
    class Program
    {
        
       static Dictionary<int, Kitap> kutuphane= new Dictionary<int, Kitap>();
       static Dictionary<int, Uye> uyeler = new Dictionary<int, Uye>();
        
        static void Main(string[] args)
        {
            var k = new Kitap("Bir kitap");
            var u = new Uye("Bir uye");

            kutuphane.Add(k.Id, k);
            Islem.Alma(k,u);
            Islem.Iade(k,u);
        }
        
    }
    
}
