using System;
using SquareLibrary;

namespace SquareFigures
{
    class Program
    {
        static void Main()
        {
            int choise;
            Console.WriteLine("Please select a shape\n 0 - Circle \n 1 - Triangle\n");
            choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 0:
                    {
                        Console.WriteLine("Please enter radius circle");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        Console.WriteLine($"Square circle = {circle.squareFig()}");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Please enter first side triangle");
                        double sideTriangle_a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter second side triangle");
                        double sideTriangle_b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter third side triangle");
                        double sideTriangle_c = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(sideTriangle_a, sideTriangle_b, sideTriangle_c);
                        Console.WriteLine($"Square triangle = {triangle.squareFig()}");
                        break;
                    }
            }

        }
    }
}
