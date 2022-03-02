using System;

namespace AlgoritmaOrnekleri
{
    class Program
    {
        static void  Main(string[] args)
        {
            string [] sayilar = new string [5];
           
         for (int i = 0; i < 5; i++)
         {
          System.Console.WriteLine(  "sayı giriniz: ");
          string [i] sayilar=Console.ReadLine(); 
         
          for (int j = 0; j <5; j++)
          {
              System.Console.WriteLine( sayilar[j]);
          }
          foreach (string item in sayilar)
          {
              int y= Convert.ToInt32(item);
          }

         }
                
        
        }



    }
}
