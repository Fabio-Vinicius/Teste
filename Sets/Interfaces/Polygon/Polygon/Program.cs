using System;
using Polygons.Library;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);
        }

        private static void DisplayPolygon(string name, dynamic WTV)
        {
            Console.WriteLine(name + "Side " + WTV.SideLength);
            Console.WriteLine(name + "Number " + WTV.NumberOfSides);
            Console.WriteLine(name + "Perimeter " + WTV.GetPerimeter());
            Console.WriteLine(name + "Area " + WTV.GetArea());
        }
    }
}
