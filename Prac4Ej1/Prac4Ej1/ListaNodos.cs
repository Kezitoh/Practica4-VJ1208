﻿using System;
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

        public void Add(object valor)
        {
            Nodo nuevo = new Nodo(valor);
            Console.WriteLine(nuevo.Dato + "aaaa");
            if(Count == 0)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Sig = nuevo;
                ultimo = nuevo;
            }
            Count++;
        }

        public bool Contains(object valor)
        {
            bool res = false;
            Nodo iterador = primero;
            Nodo nodo = new Nodo(valor);
            Console.WriteLine(nodo.Dato + "eeeeee");
            int i = 0;
            do
            {
                if (nodo.Dato == iterador.Dato)
                {
                    Console.WriteLine("Entrooooo");
                    res = true;
                }
                else
                {
                    i++;
                    iterador = iterador.Sig;
                }

            }while (i < Count && !res);
            return res;
        }

        public bool Remove(object valor)
        {
            Nodo iterador = primero;
            Nodo anterior = primero;
            while(iterador != null)
            {
                if(iterador.Dato.Equals(valor))
                {
                    if (primero == iterador) primero = iterador.Sig;
                    else if (ultimo == iterador) ultimo = anterior;
                    else anterior.Sig = iterador.Sig;
                    Count--;
                    return true;
                }else
                {
                    anterior = iterador;
                    iterador = iterador.Sig;

                }
            }
            return false;
        }

        public void Remove(Object valor)
        {
            Nodo iterador = primero.Sig;
            Nodo anterior = primero;
            while(iterador != null)
            {
                if (iterador.Dato.Equals(valor))
                {
                    anterior.Sig = iterador.Sig;
                    Count--;
                    return;
                }
                anterior = iterador;
                iterador = iterador.Sig;
            }
        }

        public Object ElementAt(int indice)
        {
            return null;
        }

        //public override string ToString()
        //{
        //    string res = "(";
        //    Nodo iterador = primero;
        //    for(int i = 0; i < Count; i++)
        //    {
        //        if (iterador == primero) res += iterador.Dato;
        //        else res += $", {iterador.Dato}";
        //        iterador = iterador.Sig;
        //    }
        //    res += ")";
        //    return res;
        //}
    }
}
