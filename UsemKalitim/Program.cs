using System;

namespace UsemKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Gorsel g = new Gorsel();
            var m = new Metin();

            var t = new TestNesne();
            System.Console.WriteLine(t);
        }
    }
}
            //// Bunları installer ve logger ı yazdıktan sonra Main de çalıştırdı.
            
            // var log = new Logger();
            // var ins = new Installer(log);

            // ins.Start();


