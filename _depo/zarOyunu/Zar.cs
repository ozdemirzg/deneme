using System;

namespace ZarOyunu
{
    class Zar
    {
        public int Deger { get; private set; }
        private int yuzeySayisi;

        public Zar()
        {
            yuzeySayisi = 6;
        }

        public int At()
        {
            var r = new Random();
            Deger = r.Next(1, yuzeySayisi + 1);
            return Deger;
        }
    }
}