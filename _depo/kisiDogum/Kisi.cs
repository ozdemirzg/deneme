using System;

namespace deneme1_2
{
    class Kisi
    {  
        // Veri
        public readonly string ad;
        public int id; // field - alan - değişken
        private static int nufus;
        // // Davranış
        // public Kisi()
        // {
        //     this.id = 0;
        // }

        // Constructor
         public Kisi(string ad)   //constructor bu ctor yazarak yaptık.
        {
            this.ad =ad;
        }

        // Overload - Aşırı yükleme
        public Kisi(int id, string ad)  //ctor yine
        {
            this.ad = ad;
            this.id = id;
        }
        /*
        Bu satırı Mainde yazdırmıştık.
         Kisi k1 = new Kisi("Ali");
           // k1.ad = "Veli";  //Bunu tekrar yapamam.chor olduğu için bir kere atama yaparım. 

           */

        //Metotlar - Davranışlar
        public int Get()
        {
            return this.id;
        }
          public void Set(int i)
        { if (i!=0)
           {   
            this.id = i;
           }
        }





        public void Selamlama()
        {
            System.Console.WriteLine("Merhaba, ben " + ad);
        }
        
        public void Dogdu()
        {
            nufus += 1;
        }

        // Metot static olmayan ? Nufusu yazdıracak
        public void NufusNedir() //buraya static yazsaydın üsteki class'ta gözükmezdi.
        {
            Console.WriteLine(nufus);
        }

            /* 
            Bunu da Mainde çalştırmıştık.
        // var g = new GeriSayim(4);
            var g2 = new GeriSayim(4, "Bitti");
            Console.WriteLine("İstek gönderildi");
            g2.Baslat(); */
        
    }

}
