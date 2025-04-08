using System;
using System.Collections.Generic;

namespace Tarea
{
    internal class NumeroRepetido
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            HashSet<int> repetidos = new HashSet<int>();

            Console.WriteLine("Ingrese números (escriba 'fin' para terminar):");

            while (true)
            {
                Console.Write("Número: ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "fin")
                {
                    break;
                }

                if (int.TryParse(entrada, out int numero))
                {
                    if (numeros.Contains(numero))
                    {
                        repetidos.Add(numero);
                    }
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número o 'fin'.");
                }
            }

            if (repetidos.Count > 0)
            {
                Console.WriteLine("Números repetidos: " + string.Join(", ", repetidos));
            }
            else
            {
                Console.WriteLine("No hay números repetidos.");
            }
        }
    }
}
