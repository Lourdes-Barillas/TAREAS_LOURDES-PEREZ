using System;

namespace ListaEnlazadaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato = 0, suma = 0;
            ListaEnlazadaSimple<int> lista = new ListaEnlazadaSimple<int>();
            Console.WriteLine("Escriba un dato");
            dato = int.Parse(Console.ReadLine());
            char[] datos = dato.ToString().ToCharArray();
            for(int i = 0; i<datos.Length; i++)
            {
                suma = suma + datos[i];
                Console.Write(datos[i] + " ");
                lista.Agregar(datos[i]);
            }
            Console.WriteLine("");
            //lista.Recorrer();
            Console.WriteLine(lista.Buscar(lista));
        }


        

        
    }
}
