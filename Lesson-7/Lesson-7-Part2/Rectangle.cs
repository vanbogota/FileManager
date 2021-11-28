using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lesson_7_Part2
{
    class Rectangle : Figure
    {
        private int _length;
        private int _width;
        public Rectangle(Color color = Color.Black, bool visible = true, int x = 0, int y = 0, int length=1, int width=1) : base(color, visible, x, y)
        {
            Length = length;
            Width = width;
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public override double Area()
        {
            return Length * Width;
        }
    }
}
