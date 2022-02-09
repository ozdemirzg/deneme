/* using System;

namespace deneme
{
    class Program
    {
        static void Main()
        {

            string deger;
            string sonDeger;

            deger = Giris(); //string geliyor
            sonDeger = Proses(deger); //string bekliyor string veriyor
            Cikis(sonDeger); //string bekliyor
        }
        static string Giris()

        {
            string girisM;

            //Giriş İşlemleri
            Console.Write("Giriş Yapınız: ");  //yanına yazdırdık sayıyı write ile.line olsa ltına yazacaktı.
            girisM = Console.ReadLine();

            if (Gecerli(girisM))
            {
               if( girisM.StartsWith('a'))
               {
                   Console.WriteLine("A ile başlıyor.");
               }
                return girisM;
            }
            else
            {
                return "TEST - Geçerli olmayan giriş";
            }
        }
        static bool Gecerli(string metin)
        {
            bool gecerli = true;
            // length(uzunluk)
            int uzunluk = metin.Length;

            //Koşul? en az 3 karakter olacak -UZUNLUK DEĞERLENDİRME
            if (uzunluk > 3) //git Gecerli() çalışsın geri gel demek.methoda atlayıp doğru mu değil mi birsürü şey yapabilirim.
            {
                gecerli = true;
            }
            else
            {
                gecerli = false;
            }

            return gecerli;
        }
        static string Proses(string g)
        {
            //String işlemler
            string cikisM;
            cikisM = "Giriş :  " + g;
            return cikisM;
        }
        static void Cikis(string c)
        {
            //Çıkış işlemleri
            Console.WriteLine(c);
        }

    }
}
 */
//DÜZENLEDİ SONRADAN TEKRAR

 using System;
namespace Usem.Calisma01
{
    class OzelProgram
    {
        static string ortadaDeger; // BUNU HEPSİNE ATADI.Buna bakacak griş proses ve cikis

        static void Main()
        {
            // Giriş
            Giris();

            // İşlemler 
            Proses();

            // Çıkış işlemler
            Cikis();

        }

        static void Giris()
        {
           
            Console.WriteLine("Giriş Yapınız...(En Az 4 Karakter)");
            ortadaDeger = Console.ReadLine();
         
            //    if (Gecerli())   //1.YOL                                                                     
            // {
            //     ortadaDeger = ortadaDeger;
            // }
            // else
            // {
            //     Giris();
            // }
      
           if (!Gecerli())   // ! Değili demek.Kısa yoldan yazmış oldu aslında..    2.YOL
           {   
             Giris();
           }

        }
        static bool Gecerli()
        {
            bool gecerli = true;

            // uzunluk hesaplama
            int uzunluk = ortadaDeger.Length;

            // uzunluk değerlendirme
            if (uzunluk > 3)
            {
                // koşul TRUE doğru ise çalıştırılır
                gecerli = true;
            }
            else
            {
                // koşul FALSE yanlış ise çalıştırılır
                gecerli = false;
            }
            return gecerli;
        }

        static void Proses()
        {
            // String işlemler
            ortadaDeger = "Giriş :  " + ortadaDeger;
        }

        static void Cikis()
        {
            // Çıkış İşlemler
            Console.WriteLine(ortadaDeger);
        }
    }
}

