using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila P = new Pila();

            P.IntertarNodo();

            Console.WriteLine("\nLas Pilas Ingresadas son: ");
            P.ImprimirPila();
        }
    }
}
