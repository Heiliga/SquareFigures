using System;
using System.Collections.Generic;
using System.Text;


namespace SquareLibrary
{
    public class Circle : Figure
    {
        public Circle (double radius)
        {
            radiusFigure = radius;
        }

        public override double squareFig()
        {
            return Square.pi * Math.Pow(radiusFigure, 2);
        }
    }
}
