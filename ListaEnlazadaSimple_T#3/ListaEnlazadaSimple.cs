using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazadaSimple
{
    class ListaEnlazadaSimple<T>
    {
        private Nodo<T> primero { set; get; }
        private Nodo<T> actual { set; get; }
        private Nodo<T> ultimo { set; get; }
        private Nodo<T> temporal { set; get; }

        public ListaEnlazadaSimple()
        {
            primero = null;
            //primero.siguiente = null;
        }

        public Nodo<T> Agregar(T pDato)
        {
            //Si no hay ningún dato, cerremos el método
            if (pDato==null)
                return null;
            else
            {
                if (primero == null)
                {
                    primero = new Nodo<T>(pDato);
                    primero.siguiente = null;
                    ultimo = primero;
                    
                }
                else
                {
                    
                        actual = ultimo;
                        if(actual.siguiente == null)
                        {
                            actual.siguiente = new Nodo<T>(pDato);
                            temporal = actual.siguiente;
                            temporal.siguiente = null;
                            ultimo = temporal;
                            actual = ultimo;
                        }
                }
            }

            return null;
        }

        public void Recorrer()
        {
            if (primero != null)
            {
                int i = 1;
                Console.WriteLine(i + ". " + primero.dato);
                actual = primero;
                do
                {
                    i++;
                    actual = actual.siguiente;
                    Console.WriteLine(i + ". " + actual.dato);
                } while (actual.siguiente != null);

            }
        }//fin del método

        public int Buscar(ListaEnlazadaSimple<int> lista)
        {
            int menor = 0;
            if (lista.primero != null)
            {
                int i = 1;
                lista.actual = lista.primero;
                menor = lista.primero.dato;
                do
                {
                    
                        i++;
                        lista.actual = lista.actual.siguiente;
                        if (lista.actual.dato < menor)
                            menor = lista.actual.dato;
                } while (lista.actual.siguiente != null);

            }
            return menor;
        }//fin del método
    }
}
