using System;

namespace Calisma12.Algoritma
{
    class SesliHarf
    {
        static void Main(string[] args)
        {
           string sesli = "a,e,ı,i,o,ö,u,ü,A,E,I,İ,O,Ö,U,Ü";
           System.Console.WriteLine( "Cümleyi giriniz" );
           string cumle =Console.ReadLine();
           int sayac = 0;
           
             for (int i = 0; i < cumle.Length; i++)
           {
              if (sesli.Contains(cumle[i]))
              {
                  sayac++;
              }
           }
         
           System.Console.WriteLine(    "Toplam sesli harf sanyın: {0} " ,sayac );
             Console.ReadLine();
        }

    

           

        
    }
}

