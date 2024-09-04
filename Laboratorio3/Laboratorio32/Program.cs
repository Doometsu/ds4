using System;

namespace Calculadora
{
    class Program
    {
   
        static double CalculoArea(double radio)
        {
            const double pi = 3.141592653589793;
            return pi * radio * radio;
        }

     
        static double Calcular(double a, double b)
        {
            return (a + b) * (a - b);
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo numero (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultadoOperacion = Calcular(a, b);

            Console.WriteLine($"El resultado de la operacion ({a} + {b}) * ({a} - {b}) es: {resultadoOperacion}");

            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = CalculoArea(radio);

            Console.WriteLine($"El área del círculo con radio {radio} es: {areaCirculo}");
        }
    }
}
