using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food teste = new Food("teste");
            Food teste2 = new Food("teste");
            Food choc = new Food("choc");



            Console.WriteLine(teste.Equals(choc));
            Console.WriteLine(teste.Equals(teste2));
            Console.WriteLine(teste);
            Console.WriteLine(teste2);
        }
    }
}
