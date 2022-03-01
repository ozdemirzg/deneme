using System;

namespace AlgoritmaOrnekleri
{
    class Ornek
    {
      
      public Ornek()
      {
        
      }
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
        public static void IkiSayininBölmü()
        {
           int sayi1,sayi2;
            Console.WriteLine(  "sayi1:  ");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  "sayi2:  ");
            sayi2=Convert.ToInt32(Console.ReadLine());
          if (sayi1%sayi2==0)
          {
              System.Console.WriteLine( $"{sayi1} {sayi2}'e tam bölünür.");
          }
          else
          {
              System.Console.WriteLine( $"{sayi1} {sayi2}'e tam bölünmez.");

          }
           if (sayi2%sayi1==0)
          {
              System.Console.WriteLine( $"{sayi2} {sayi1}'e tam bölünür.");
          }
          else
          {
              System.Console.WriteLine( $"{sayi2} {sayi1}'e tam bölünmez.");
              
          }
           if (sayi1==sayi2)
          {
              System.Console.WriteLine( $"{sayi1} {sayi2}'ye tam bölünür.");
          }
          //2.YOL
          /* Console.WriteLine("Girilen İki Sayıyı Kontrol Eden Bir Program.");
             Console.Write("Lütfen 1. Sayıyı Giriniz = ");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.Write("Lütfen 2. Sayıyı Giriniz = ");
             int b = Convert.ToInt32(Console.ReadLine());
             if (a > b)
             {
                 if (a % b == 0)
                 {
                    Console.Write(a + " Sayısı " + b + " Sayısına Tam Bölünüyor");
                 }
                else
                 {
                    Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                 }
             }
             else
             {
                 if (b % a == 0)
                 {
                    Console.Write(b + " Sayısı " + a + " Sayısına Tam Bölünüyor.");
                 }
                 else
                 {
                    Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                 }
             } */

        }
        public static void GecmeNotu ()
        {
           System.Console.Write("Not: ");
           int not = int.Parse(Console.ReadLine());
           if (not<45 )
           {
               System.Console.WriteLine( "Kaldı..");
           }
           else if (not>=45 && not<=100 )
           {
               System.Console.WriteLine( "Geçti..");
           }
           else
           {
               System.Console.WriteLine(    "Yanlş veri girdiniz.");
               
           }
        }
        public static void TamSayi()
        {
          System.Console.WriteLine( "SAYI: ");
          int sayi = int.Parse(Console.ReadLine());
          if (sayi>0)
          {
              System.Console.WriteLine("Sayi poz.");
          }
          else if (sayi<0)
          {
              System.Console.WriteLine("Sayi neg.");
          }
          else
          {
              System.Console.WriteLine( "sayi sıfır.");
          }

        }
         public static void BuyukSayi()
         {
            
         }
    }

}