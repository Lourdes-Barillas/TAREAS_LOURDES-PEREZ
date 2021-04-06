using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazadaSimple
{
    class Nodo<T>
    {
        public Nodo<T> siguiente { set; get; }
        public T dato { set; get; }

        public Nodo(T pDato)
        {
            siguiente = null;
            dato = pDato;
        }

    }
      
}
