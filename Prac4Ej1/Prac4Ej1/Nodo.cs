using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac4Ej1
{
    internal class Nodo
    {
        public object Dato { get; set; }
        public Nodo Sig { get; set; }
        public Nodo(object dato)
        {
            Dato = dato;
            Sig = null;
        }

        //public override string ToString()
        //{
        //    return Dato.ToString();
        //}
    }
}
