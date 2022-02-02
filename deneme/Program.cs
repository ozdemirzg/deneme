using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            
                 //veri yapıları bu ikisi
                string deger;  
                string sonDeger;

                //bu üçü de algoritma
                deger = Giris(); //string geliyor
                sonDeger = Proses(deger); //string bekliyor string veriyor
                Cikis(sonDeger); //string bekliyor
        }
            static string Giris()

            {
                string girisM;
                
                //Giriş İşlemleri
                Console.Write("Sayıyı Girin: ");  //yanına yazdırdık sayıyı write ile.line olsa ltına yazacaktı.
                girisM = Console.ReadLine();
                return girisM;
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
