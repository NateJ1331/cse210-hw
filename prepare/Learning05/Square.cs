namespace Learnig05
{
    class Square:Shape
    {
        private double _side;

        public Square(string color, double side)
        {
            this.SetColor(color);
            _side = side; 
        }

        public override double GetArea()
        {
            _side = 5;

            return _side*_side;
        }
    }
    
}