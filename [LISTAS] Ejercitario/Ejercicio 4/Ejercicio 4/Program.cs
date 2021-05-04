using System;
using System.Collections.Generic;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;

            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);


            imprimeListaInversa(i);

            void imprimeListaInversa(int x)
            {
                if (x >= 0)
                {
                    Console.WriteLine(lista[x]);
                    x--;
                    imprimeListaInversa(x);
                }
            }

        }

    }
}
