using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lesson_7_Part2
{
    class Point : Figure
    {
        public Point(Color color = Color.Black, bool visible = true, int x = 0, int y = 0) : base(color, visible, x, y)
        {            
        }

        public override double Area()
        {
            return 0;
        }
    }
}
