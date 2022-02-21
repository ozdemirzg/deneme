using System;

namespace UsemKutuphane
{
    // Kutuphane ile ilgili işler bir arada 
    class Islem
    {
        public static void Alma(Kitap k, Uye u)
        {
            k.Uyeler.Add(u);//listeye erişebiliyorsun burada. ama ekleme yapamazsında.set private çünkü.!
            Console.WriteLine($" {u.Ad} ödünç aldı. {k.Ad} ");
            
        }

        public static void Iade(Kitap k, Uye u)
        {
            k.Uyeler.Remove(u);
            Console.WriteLine($" {u.Ad} iade etti. {k.Ad}");
        }




    }
    
}