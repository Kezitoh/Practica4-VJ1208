using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac4Ej1
{
    internal class Nodo
    {
        public Object Dato { get; set; }
        public Nodo Sig { get; set; }
        public Nodo(object dato, Nodo sig)
        {
            this.Dato = dato;
            this.Sig = sig;
        }
    }
}
