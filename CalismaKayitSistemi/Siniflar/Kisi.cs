namespace CalismaKayitSistemi.Siniflar
{
    enum CalisanBolumler
    {
        Yemek,
        Temizlik,
        İdari
    }
     enum EgitmenBolum
    {
        Fen,
        Matematik,
        Sosyal
    }

    class Kisi 
    {
        // public static string kurumAd;
        protected string TcNo { get; set; }
        protected string AdSoyad { get; set; }

    }

}