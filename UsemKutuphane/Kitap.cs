using System;

namespace UsemKutuphane
{
    class Kitap
    {
        // Veri
        // id'lerin kontrollu olarak belirlenmesi
        public int Id { get; set; }
        public string Ad { get; set; }

        
        // constructor
        public Kitap(string ad)
        {
            this.Ad = ad;     
        }
        
    }
    
}