using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac4Ej1
{
    internal class ListaNodos
    {
        private Nodo primero;
        private Nodo ultimo;
        public int Count { get; private set; }

        public ListaNodos()
        {
            primero = ultimo = null;
            Count = 0;
        }

        public bool IsEmpty()
        {
            return (Count == 0);
        }

        public void Add(Object valor)
        {

        }

        public bool Contains(Object valor)
        {
            return false;
        }

        public void Remove(Object valor)
        {

        }

        public Object ElementAt(int indice)
        {
            return null;
        }

        public override string ToString()
        {
            return "Nada";
        }
    }
}
