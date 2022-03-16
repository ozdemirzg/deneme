using System;

namespace Banka
{
    class Islem
    {
        public decimal Miktar { get; }
        public DateTime Tarih { get; }
        public string Not { get; }

        public Islem(decimal miktar, DateTime tarih, string not) //Islem.ile çağırabilmek için yazdık.
        {
            Miktar = miktar;
            Tarih = tarih;
            Not = not;
        }
        public Islem(decimal miktar, DateTime tarih)
        {
            Miktar = miktar;
            Tarih = tarih;
            Not = "! Açıklama girilmedi.";

        }
          public Islem(decimal miktar, string not)
        {
            Miktar = miktar;
            Tarih = DateTime.Now;
            Not = not;
        }
        public Islem(decimal miktar)
        {
            Miktar = miktar;
            Tarih = DateTime.Now;
            Not = "! Açıklama girilmedi.";
        }
      








    }
}
