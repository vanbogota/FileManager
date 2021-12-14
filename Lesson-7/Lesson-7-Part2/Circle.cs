using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lesson_7_Part2
{
    class Circle : Point
    {
        private int _radius;

        public Circle(Color color = Color.Black, bool visible = true, int x = 0, int y = 0, int radius = 1) : base(color, visible, x, y)
        {
            Radius = radius;
        }

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public override double Area()
        {
            return Math.PI*Radius*Radius;
        }
    }
}
