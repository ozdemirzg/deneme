using System;
using System.Collections.Generic;

namespace UsemKutuphane
{
    class Kitap
    {
        // Veri
        // id'lerin kontrollu olarak belirlenmesi
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Uye> Uyeler { get; private set; } 

        
        // constructor
        public Kitap(string ad)
        {
            Uyeler = new List<Uye>();
            this.Ad = ad;     
        }
        
    }
    
}