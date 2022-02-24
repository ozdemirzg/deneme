namespace CalismaKayitSistemi.Siniflar
{
    class Destek : Calisan
    {
        private CalisanBolumler _bolum { get; set; }  //enum tanımladığımız enumdan yazacağımız için bölümler dedik.
        //ctor
        public Destek(CalisanBolumler bolum, string sgkNo, string tcNo, string adSoyad)
        : base(sgkNo, tcNo, adSoyad)
        {
            _bolum = bolum;
        }

    }

}