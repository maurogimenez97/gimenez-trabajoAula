using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();
            c.IntertarNodo();
            c.IntertarNodo();
            c.IntertarNodo();
            c.IntertarNodo();
            Console.WriteLine("\n Colas Ingresado");
            c.ImprimirCola();
        }
    }
}
