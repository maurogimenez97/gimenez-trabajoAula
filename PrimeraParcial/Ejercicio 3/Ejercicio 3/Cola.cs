using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class Cola
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Cola ()
        {
            Primero = null;
            Ultimo = null;
        }



        public void IntertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato para la cola");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                Primero = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }

            Console.WriteLine("Ingresado");



        }

        public void ImprimirCola()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\nLa Cola esta vacia");
            }
        }
    }
}
