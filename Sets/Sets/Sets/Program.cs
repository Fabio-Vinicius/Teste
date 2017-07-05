using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new SortedSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {"NY", "Manc", "Shef", "Par"};
            cities.Add("SHEF");
            cities.Add("PAR");

            foreach (string item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
