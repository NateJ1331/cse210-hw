namespace Learnig05
{
    class Rectangle:Shape
    {
        double _width;
        double _height;

        public Rectangle(string color, double width, double height)
        {
            this.SetColor(color);
            _width = width;
            _height = height;
        }
        public override double GetArea()
        {
            return _width*_height;
        }
    }
}