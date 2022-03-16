using System;

namespace AlgoritmaOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
          LoveFunc(3, 4);
        }
        public static void LoveFunc(int flower1, int flower2)
        {

            if (flower1 % 2 == 0 || flower2 % 2 != 0)
            {
                Console.WriteLine("They are in love");
            }
            else if (flower2 % 2 == 0 || flower1 % 2 != 0)
            {
                Console.WriteLine("They are in love");
            }
            else
            {
                Console.WriteLine("They aren't in love");
            }

        }


    }
}
