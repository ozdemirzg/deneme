namespace CalismaKayitSistemi.Siniflar
{
    class Egitmen : Calisan, IkBahseden
    {
        public EgitmenBolum _bolum;
        //ctor
        public Egitmen(EgitmenBolum bolum, string sgkNo, string tcNo, string adSoyad)
        :base(sgkNo, tcNo, adSoyad)
        {
             _bolum = bolum;
        }




    }

}