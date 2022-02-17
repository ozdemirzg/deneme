using System;

namespace UsemKutuphane
{
    // Kutuphane ile ilgili işler bir arada 
    class Islem
    {
        public static void Alma(Kitap k, Uye u)
        {
            var ik = new IslemKayit();
            Console.WriteLine("Ödünç alındı");

        }




        public static void Iade(Kitap k, Uye u)
        {
            Console.WriteLine("İade edildi.");
        }

    }
    
}