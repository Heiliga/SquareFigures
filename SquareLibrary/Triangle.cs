using System;
using System.Collections.Generic;
using System.Text;

namespace SquareLibrary
{
    public class Triangle : Figure
    {
        private double maxSide;
        private double minSide_1;
        private double minSide_2;
        public Triangle(double a, double b, double c)
        {
            sideFigure_a = a;
            sideFigure_b = b;
            sideFigure_c = c;
            perimeterFigure = (a + b + c) / 2;
        }

        private bool rectangularTriangle()
        {
            maxSide = Math.Max(sideFigure_a, sideFigure_b);
            minSide_1 = Math.Min(sideFigure_a, sideFigure_b);
            minSide_2 = Math.Min(maxSide, sideFigure_c);
            maxSide = Math.Max(maxSide, sideFigure_c);

            if (Math.Pow(maxSide, 2) == Math.Pow(minSide_1, 2) + Math.Pow(minSide_2, 2))
                return true;
            else
                return false;
        }
        public override double squareFig()
        {
            if (rectangularTriangle())
                return minSide_1 * minSide_2 / 2;
            else
                return Math.Sqrt(perimeterFigure*(perimeterFigure-sideFigure_a)*
                    (perimeterFigure-sideFigure_b)*(perimeterFigure-sideFigure_c));
        }
    }
}
