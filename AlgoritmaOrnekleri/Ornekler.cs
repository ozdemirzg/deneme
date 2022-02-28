using System;

namespace AlgoritmaOrnekleri
{
    class Ornek
    {
        public static void  KDV()
        {
         
          float fiyat,kdv,oran,tutar;
          Console.Write("Fiyat: " );
          fiyat =Convert.ToSingle(Console.ReadLine()); //ondalığa çevirdik ToSingle ile.
          Console.Write("KDV Oranı:   ");
          oran =Convert.ToSingle(Console.ReadLine());
          kdv= oran*fiyat;
          tutar=fiyat+kdv;
          Console.WriteLine("tutar= {0:f2}     kdv= {1} ", tutar,kdv  ); //f2 ondalık kısmıda yazdırır.
                
        }

        public static void DereceCevrim()
        {
          double tf , tc;
          Console.Write("C: " );
          tc=double.Parse( Console.ReadLine());
          tf= tc*1.8 +32;
          Console.WriteLine(tf);
        }
        
        public static void EhliyetYas()
        {
           int yas;
          Console.WriteLine("Yaş: " );
          yas= Convert.ToInt32(Console.ReadLine() );
 
          if (yas>18)
          {
              Console.WriteLine("alabilir.");
          }
          else
          {
              Console.WriteLine("alamaz.");  
          }
        }
        public static void UcgenAlan()
        {
          int taban, yukseklik,alan ;
            System.Console.WriteLine("Taban uzunluğu: ");
            taban=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Yükseklik: ");
            yukseklik=Convert.ToInt32(Console.ReadLine());
            alan=(taban*yukseklik)/2;
            System.Console.WriteLine( "üçgenin alanı: {0}" , alan);
        }
        public static void Pisagor()
        {
          double z,y,x;
            Console.Write("1.kenar uzunluğunu giriniz:");
            x=double.Parse(Console.ReadLine());
            Console.Write("2.kenar uzunluğunu giriniz:");
            y=double.Parse(Console.ReadLine());
            z=Math.Sqrt(x*x+y*y);
            System.Console.WriteLine(z);
        }
    }
}