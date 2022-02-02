using System;

namespace Usem.calisma01
{
    class OgrenciKayit
    {
        static void Main(string[] args)
        {
            string mesaj = "Merhaba Dünya!"; // string olarak tanımlayınca mesaj class a dönüştü.?
            bool bitti = true;
            var m = 4;
            var mesaj2 = "Selam!"; //metinde " kullanmak zorundasın.sayıda fark etmiyor.VAR için.
            float hiz = 30.12f; //. olduğu için f ile ondalıklı olarak algılamasını sağlıyor.
            // float hiz2 =30f; //f ondalık kısmına denk gelir.
            char tek = '.';
            int sayi = 3;  //assign=atama //assign ın sağ tarafında sonsuz şey olabilir.sol tarafında 1 tane şey vardır.

            /* Console.WriteLine(sayi);
            Console.WriteLine(mesaj);
            Console.WriteLine(bitti);
            Console.WriteLine(tek);
            Console.WriteLine(hiz);
            Console.WriteLine(mesaj2);
            Console.WriteLine(m); 
            kısaca yazmak i.in alttakini kullandı
            */

            Console.WriteLine(sayi + " " + mesaj + " " + bitti + " " + tek + " " + hiz + " " + mesaj2 + " " + m);
            Console.WriteLine(); // bir satır boşluk bırakır
            Console.Write($"{sayi} tektir. "); // bıraktığın yerden bir sonrakini yazmaya devam eder.
            Console.WriteLine(sayi + " " + mesaj + " " + bitti + " " + tek + " " + hiz + " " + mesaj2 + " " + m);
            ///////------------------------------------------------------
            // Console.ReadLine(); // kullanıcın giriş yapması için.
            int say = Convert.ToInt32(Console.ReadLine());
            int say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(say * say1);
            /////--------------------------

            
           

            
          

            





        }
    }

}
