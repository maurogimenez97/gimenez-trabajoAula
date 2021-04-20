using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    class Pila
    {
        private Nodo Primero = new Nodo();

        public Pila()
        {
            Primero = null;
        }

        public void IntertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato de la Pila");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            Nuevo.Siguiente = Primero;
            Primero = Nuevo;

            Console.WriteLine("\nIngresado");
        }

        public void ImprimirPila()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                    Actual = Actual.Siguiente;
                    Actual = Actual.Siguiente;
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\nLa Pila esta vacia");
            }
        }
    }
}
