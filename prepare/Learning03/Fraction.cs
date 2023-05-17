namespace Learning03
{
    class Fraction
    {
        private double _top;
        private double _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public string GetString()
        {
            return $"{_top}/{_bottom}";
        }

        public double GetDecimalValue()
        {
            return _top/_bottom;
        }



    }
}