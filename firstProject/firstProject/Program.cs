using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Input das medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Input das medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área de X = " + x.Area().ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + y.Area().ToString("F4", CultureInfo.InvariantCulture));

            if (x.Area() > y.Area()) {
                Console.WriteLine("Área de X maior que de Y ");
            } else {
                Console.WriteLine("Área de Y maior que de X ");
            }
        }
    }
}
