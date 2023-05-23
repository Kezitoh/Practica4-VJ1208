using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prac4Ej1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ListaNodos listaNodos = new ListaNodos();

            listaNodos.Add(12);
            listaNodos.Add(14);
            listaNodos.Add(15);
            Console.WriteLine(listaNodos);
            Console.WriteLine(listaNodos.Contains(14));
            listaNodos.Remove(14);
            Console.WriteLine(listaNodos);
        }
    }
}
