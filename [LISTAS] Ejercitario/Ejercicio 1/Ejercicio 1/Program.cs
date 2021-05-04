using System;
using System.Collections.Generic;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            List<int> lista = new List<int>();

            Console.WriteLine("Ingrese un numero del 0 al 100: ");
            for (int i = 0; i < 25; i++)
            {
                int numero = Int32.Parse(Console.ReadLine());
                lista.Add(numero);
            }

            foreach (int num in lista)
            {
                suma += num;
            }

            int promedio = suma / 25;

            Console.WriteLine("La suma es = " +suma);
            Console.WriteLine("El promedio es = " +promedio);


        }
    }
}
