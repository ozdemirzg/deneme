using System;

namespace Usem.Yardimcilar
{

    class Konsol
    {
        public static void KonsolLog(string kod, string mesaj)
        {
          Console.ResetColor();

            switch (kod)
            {
                case "info":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "hata":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "uyari":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
            
            Console.WriteLine(mesaj);
            Console.ResetColor();
            /* BU üsttekini çalıştırmak için DİĞER DOSYADA MAİNDE YAZDIRDIK SONRA
          Konsol.KonsolLog("info", "deneme olarak info....");
          Console.WriteLine("vcvcvcc");
          Konsol.KonsolLog("hata", "deneme olarak info...."); 
          */
        }
           public static int ReadInt()
        {
            // string s = "";
            // int a;

            // while (!(int.TryParse(s, out a)))
            // {
            //     s = Console.ReadLine();
            // }
            // return a;

            //2.yol
            string s;
            int a;

            do
            {
                s = Console.ReadLine();
            }
            while (!(int.TryParse(s, out a)));
            return a;

           /// System.Console.WriteLine(Konsol.ReadInt()); //bunu mainde yazdırdı

        }
    

        

    }
    
}