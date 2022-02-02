using System;

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
