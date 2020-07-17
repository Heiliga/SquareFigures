using System;
using System.Collections.Generic;
using System.Text;

namespace SquareLibrary
{
    public abstract class Figure : ISquare
    {
        public double sideFigure_a { get; set; }
        public double sideFigure_b { get; set; }
        public double sideFigure_c { get; set; }
        public double sideFigure_d { get; set; }
        public double perimeterFigure { get; set; }
        public double heightFigure { get; set; }
        public double radiusFigure { get; set; }
        public double cornerFigure { get; set; }


        public virtual double squareFig() 
        {
            return perimeterFigure/2*radiusFigure;
        }
    }
}
