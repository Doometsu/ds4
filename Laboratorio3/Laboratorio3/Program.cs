using System;

namespace OperacionMatematica
{
    public class CalculosMatematicos
    {
        public static double Calcular(double a, double b)
        {
            return (a + b) * (a - b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = CalculosMatematicos.Calcular(a, b);

            Console.WriteLine($"El resultado de la operación (a + b) * (a - b) es: {resultado}");
        }
    }
}
