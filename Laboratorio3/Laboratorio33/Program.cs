using System;

namespace OperacionMatematica
{
    public class CalculosMatematicos
    {
        public static double Calcular(double a, double b)
        {
            return (a + b) * (a - b);
        }
        public static double CalculoArea(double radio)
        {
            const double PI = 3.141592653589793;
            return PI * radio * radio;
        }
        public static double CalcularPerimetro(double lado1, double lado2)
        {
            return 2 * (lado1 + lado2);
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

            double resultadoOperacion = CalculosMatematicos.Calcular(a, b);

            Console.WriteLine($"El resultado de la operación (a + b) * (a - b) es: {resultadoOperacion}");

            Console.WriteLine("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = CalculosMatematicos.CalculoArea(radio);

            Console.WriteLine($"El área del círculo con radio {radio} es: {areaCirculo}");

            Console.WriteLine("Ingrese el primer lado del rectángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado del rectángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            double perimetroRectangulo = CalculosMatematicos.CalcularPerimetro(lado1, lado2);

            Console.WriteLine($"El perímetro del rectángulo con lados {lado1} y {lado2} es: {perimetroRectangulo}");
        }
    }
}
