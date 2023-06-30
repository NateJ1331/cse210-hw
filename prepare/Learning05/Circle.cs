namespace Learnig05
{
    class Circle:Shape
    {
        private double _radius;

        public Circle(string color, double radius)
        {
            this.SetColor(color);
            _radius = radius; 
        }

        public override double GetArea()
        {
            _radius = 5;

            double area = Math.Round(Math.PI*(_radius*_radius),2);

            return area;
        }
    }
    
}