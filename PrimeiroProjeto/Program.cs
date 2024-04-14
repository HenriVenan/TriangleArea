using System;
using System.Globalization;

namespace TriangleArea
{
    class TriangleArea 
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.Write("Entre com as medidas do Triângulo X: ");

            Console.Write("\n\nMedidada do 1º lado: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Medidada do 2º lado: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Medidada do 3º lado: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do Triângulo Y: ");

            Console.Write("\nMedidada do 1º lado: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Medidada do 2º lado: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Medidada do 2º lado: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("\nArea de X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("\nA área do Triângulo X é maior");
            } else
            {
                Console.WriteLine("\nA área do Triângulo Y é maior");
            }
        }
    }
}