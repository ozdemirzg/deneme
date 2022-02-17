using System.Threading;
using System;
using Usem.OrnekSiniflar;
using deneme1_2;

namespace Usem.Ana
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new Kisi("Ali");
            k.Set(3);

            var i = k.Get();

            Console.WriteLine(i);
        }
    }
}
