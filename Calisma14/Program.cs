using System;

namespace KisiNakit
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Kisi("Ali", 50);
            var v = new Kisi("Veli", 50);


            while (true)
            {
               a.BilgileriYaz();
               v.BilgileriYaz();
                // Ne kadar?
                Console.Write("Ne kadar?");
                int miktar = Convert.ToInt32(Console.ReadLine());

                // Kim?
                Console.Write("Kim nakit veriyor (a ya da v");
                string kim = Console.ReadLine();

                if (kim == "a")
                {
                    int m = a.NakitVer(miktar);
                    v.NakitAl(m);

                }
                else if (kim == "v")
                {
                    int m = v.NakitVer(miktar);
                    a.NakitAl(m);
                }
                else
                {
                    System.Console.WriteLine("Doğru giriş yapın..");
                }
            }
        }
    }
}
