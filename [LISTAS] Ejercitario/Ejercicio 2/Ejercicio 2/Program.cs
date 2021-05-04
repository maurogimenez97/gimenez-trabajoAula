using System;
using System.Collections.Generic;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();

            Console.WriteLine("Ingrese 10 letras: ");
            for (int i = 0; i < 9; i++)
            {
                string numero = (Console.ReadLine());
                lista.Add(numero);
            }
            
            lista.Reverse(); // Utilizamos el metodo Reverse para invertir el orden de la lista
            Console.WriteLine("Su inversa es: ");

            foreach (string num in lista)
            {
                string inversa = num;
                Console.WriteLine("" + inversa);
            }
        }
    }
}
