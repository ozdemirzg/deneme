using System;

namespace Calisma13
{
    class Program
    {
        static void Main(string[] args)
        {

            // Polygon polygon = new Polygon(3); // a triangle
            // Square square = new Square(4.5f); // a square, which is a polygon with 4 sides of length 4.5.

            // Polygon polygon = new Square(4.5f);
            // Square square = new Polygon(3); // Does not compile.

            // Polygon polygon = new Square(4.5f);






            // if (polygon is Square)
            // {
            //     Square square = (Square)polygon;
            //     // We can now do what we want with the square.
            // }


            // Polygon polygon = new Square(4);
            // Square square = polygon as Square;


            Polygon polygon = new Triangle();
            Square square = polygon as Square;

            if (square != null)
            {
                // ...
                System.Console.WriteLine("NULL DEĞİL");
            }

            if (polygon is not Square)
            {
                System.Console.WriteLine("KARE değildir");
            }
        }
    }


    // Poligon
    class Polygon
    {
        public int NumberOfSides { get; set; }
        public Polygon()
        {
            NumberOfSides = 0;
        }
        public Polygon(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }

    class Square : Polygon
    {
        public float Size { get; set; }
        public Square(float size)
        {
            Size = size;
            NumberOfSides = 4;
        }
    }

    class Triangle : Polygon
    {

    }


    // Kisi

    class Kisi
    {
        public int Id { get; set; }

    }

    class Ogrenci : Kisi
    {
        public string Ad { get; set; }

    }
    class Egitmen
    {
        public string Ad { get; set; }

    }
}
