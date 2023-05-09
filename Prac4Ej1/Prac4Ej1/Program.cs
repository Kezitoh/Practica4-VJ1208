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

            listaNodos.Add(new Nodo(12));
            Console.WriteLine(listaNodos.ToString());
        }
    }
}
