
/*
			
- vadeli 
		-ay sonu faiz işler, %2
		
- kredi hesabı 
	- negatif bakiye olabilir, 
	- ay sonu negatif bakiye için faiz işler. 
	- negatif bakiye kredi limitini aşamaz. 
	- Her para çekildiğinde sabit bir ücret alınır. Bu ücret limitten düşer.)

- hediye/cüzdan hesabı 
	- sadece ödeme yapabilir. 
	- aysonunda belirlenen miktarda yükleme yapılabilir.
*/

using System;
using System.Collections.Generic;
using System.Threading;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            var vadeli = new VadeliHesap("Vadeli", 100);
            var kredi = new KrediHesabi("Kredi", 100);
            var hediye = new HediyeCuzdan("Hediye", 30, 20);

            List<BankaHesabi> hesaplar = new();

            vadeli.ParaCek(10);
            kredi.ParaCek(120);
            hediye.ParaCek(30);

            vadeli.AySonuIslem();
            kredi.AySonuIslem();
            hediye.AySonuIslem();

            vadeli.IslemGecmisi();
            kredi.IslemGecmisi();
            hediye.IslemGecmisi();

        //    System.Console.WriteLine("START : " + DateTime.Now.Minute + DateTime.Now.Second);
        //     var hesap1 = new BankaHesabi("Benim", 100);
        //     var hesap2 = new BankaHesabi("Senin");

        //     hesap1.ParaYatir(100, "kazanç");
        //     Thread.Sleep(1000);
        //     hesap2.ParaYatir(300, "maaş");
        //     Thread.Sleep(1000);
        //     hesap1.ParaCek(30);
        //     Thread.Sleep(1000);
        //     hesap2.IslemGecmisi();
        //     System.Console.WriteLine("START : " + DateTime.Now.Minute + DateTime.Now.Second);
        }
    }


}
