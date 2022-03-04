using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev1
{
    class Metin
    {
        static List<string> metinler = new List<string>();

        static char[] sesliHarf = new char[] { 'a','e','ı','i','o','ö','ü','u','A','E','I','İ','O','Ö','U','Ü'};

        public static void metinEkle (string metin)
        {
          metinler.Add(metin); 
        }
        public static void MetinListe()
        { 
            foreach (var m in metinler)
          {
             Console.WriteLine(m);
          }       
        }

        

        public static void SesliTotal ()
        {
            int sesliTotal=0;
           
           foreach (string m in metinler)
           {
               for (int i = 0; i <= m.Length; i++)
               {
                   if (m.Contains(sesliHarf[i]))
                   {
                       sesliTotal++;
                   }
                   
               }
           }
                       System.Console.WriteLine(sesliTotal);
           
        }
        public static void SessizTotal()
        {
          int sessizTotal=0;

          foreach (string m in metinler)
           {
               for (int i = 0; i < m.Length; i++)
               {
                   if (! m.Contains(sesliHarf[i]))
                   {
                       sessizTotal++;
                   }
               }
           }
                       System.Console.WriteLine(sessizTotal);


        }


        
    }
}
