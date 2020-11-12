using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RectangleAndCircle
{
    class Rectangle

    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Width * Length;
        }
        public double CalculatePerimeter()
        {

            return 2 * (Width + Length);
        }
    
    
    }
}
