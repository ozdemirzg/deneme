using System;

namespace HesapMakinası
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İki sayi giriniz.");
           
            Console.Write("Birinci sayi:  ");
            int x =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string giris =Console.ReadLine();

            Console.Write("İkinci sayi:   ");
            int y =Convert.ToInt32(Console.ReadLine());
         
             switch (giris)
            {
                case "+":
                Toplama(x,y);
                break;
                
                default:
                Console.WriteLine("Yanlış giriş yaptınız.Tekrar giriş yapınız!");
                break;
            }
         

            Islem();
            
            
        }

        public static void Islem() 
        {
              
        }

        static int Toplama(int x ,int y)
        {
            int toplam = x +y;
            Console.WriteLine(toplam);
            return toplam;
        }
        static void Cikarma(int x, int y)
        {
            int cikar= x-y;
            Console.WriteLine(cikar);
            
        }
        static void Bolme(int x, int y)
        {
            int bolum =x/y;
            Console.WriteLine(bolum);
        }
        static void Carpma(int x,int y)
        {
            int carpma = x*y;
            Console.WriteLine(carpma);
        }
    }
}
