using InheritanceAbstractsMethods.Entities;
using InheritanceAbstractsMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace InheritanceAbstractsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.WriteLine("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if ('r' == ch)
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                } else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("Areas: ");
            foreach (Shape s in list)
            {
                Console.WriteLine("Figure color: " + s.Color.ToString()  + " - Area: " + s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
