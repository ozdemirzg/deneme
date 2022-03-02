using System;

namespace Proje
{
    class Top
    {
        private int _r;
        public Renk _renk { get; private set; }
        public int _patlak { get; private set; }
        
        public Top (int r, Renk renk)
        {
            _r=r;
            _renk=renk;
        }
        public static void Patlat()
        {
            Top t= new Top(5,);
        }
    

    }
}
