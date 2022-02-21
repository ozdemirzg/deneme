using System.Collections.Generic;

namespace CalismaKayitSistemi.Siniflar
{
    class Ogrenci : Kisi
    {
        public string No { get; set; }
        public string Bolum { get; set; }
        public List<Ders> AldigiDersler { get; set; }
        

    }

}