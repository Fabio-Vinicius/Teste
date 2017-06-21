using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            NomBlankStringList lst = new NomBlankStringList();

            lst.Add("Add at index 0");
            lst[0] = "Item changed at 0";

            lst.Add("Add at index 1");
            lst.Insert(2, "Item changed at 2");

            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }
        }
           
    }
}
