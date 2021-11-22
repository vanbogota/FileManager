using System;

namespace Lesson_6_FigureClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Figure(Color.Red, true, 0, 0);

            Console.WriteLine(fig.ToString());

            fig.MoveGorizontal(1);

            Point p = new Point();
            p.MoveGorizontal(12);
            p.MoveVertical(3);
            p.Color = Color.Blue;
            Console.WriteLine(p.ToString());

            Circle c = new Circle();
            
            Console.WriteLine(c.ToString());

            var s = c.Square(12);

            Console.WriteLine("S = "+s);

            Rectangle r = new Rectangle();

            s = r.Square(2, 3);

            Console.WriteLine("S2 = "+s);
        }
    }
}
