namespace Formkontrollsystem
{
    internal class Triangle : Shape
    {
        private double _base { get; set; }
        private double _height { get; set; }

        public Triangle(string name, string color, double baseOfTriangle, double height)
        {
            Name = name;
            Color = color;
            _base = baseOfTriangle;
            _height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * _base * _height;
        }
    }
}
