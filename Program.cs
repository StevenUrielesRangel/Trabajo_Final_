namespace Tarea.Geometría_A
{
    internal class _1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a calcular el area y el perimetro de un cuadrado");
            Console.WriteLine("Ingrese la lingitud de una de las caras del Cuadrado: ");
            double a = double.Parse(Console.ReadLine());

            double area = a * a;
            double perimetro = a * 4;

            Console.WriteLine("El area del cuadrado es: " + area + "y el perimetro es: " + perimetro);
        }
    }
}
