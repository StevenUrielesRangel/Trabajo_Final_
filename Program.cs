using System;

namespace ComprobarVocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese unan vocal:");
            char letra = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es una vocal.");
                    break;
            }
        }
    }
}
