using System;
using System.Collections.Generic;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i = 0;

            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);

            Console.WriteLine("Ingrese el numero a buscar");

            numero = Int32.Parse(Console.ReadLine());

            buscarLista(numero, i);

            void buscarLista(int x, int y)
            {

                if (y > 3)
                {
                    Console.WriteLine("NULL");
                }

                else if (lista[y] == x)
                {
                    Console.WriteLine("El numero a buscar se encontro, es el: " + x);
                }
                else if (y <= 4)
                {
                    y++;
                    buscarLista(x, y);
                }
            }

        }

    }
}
