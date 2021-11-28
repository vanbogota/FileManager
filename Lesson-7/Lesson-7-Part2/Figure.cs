
namespace Lesson_7_Part2
{
    abstract class Figure
    {
        public int X;
        public int Y;
        bool _visible;
        Color _color;
        
        public Figure(Color color = Color.Black,
                      bool visible = true,
                      int x = 0,
                      int y = 0)
        {
            Color = color;
            Visible = visible;
            X = x;
            Y = y;
        }
        public bool Visible
        {
            get
            {
                return _visible;
            }
            set
            {
                _visible = value;
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public override string ToString()
        {
            return $"Color: {Color};\n" +
                $"Visible: {Visible};\n" +
                $"X = {X}; Y = {Y}";
        }

        public void ChangeColor(Color color)
        {
            Color = color;
        }

        public bool IsVisible(Figure figure)
        {
            return figure.Visible;
        }

        virtual public void MoveGorizontal(int deltaX)
        {
            X += deltaX;
        }
        virtual public void MoveVertical(int deltaY)
        {
            Y += deltaY;
        }
        abstract public double Area();
    }
}
