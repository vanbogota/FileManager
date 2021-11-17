using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6_FigureClass
{
    public class Circle : Point
    {
        public double Square(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Square(double diametr)
        {
            return Math.PI * Math.Pow(diametr,2)/4;
        }
    }
}
