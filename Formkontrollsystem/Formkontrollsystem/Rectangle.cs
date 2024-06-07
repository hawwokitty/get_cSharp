namespace Formkontrollsystem
{
    internal class Rectangle : Shape
    {
        private double _length { get; set; }
        private double _width { get; set; }
        public Rectangle(string name, string color, double length, double width)
        {
            Name = name;
            Color = color;
            _length = length;
            _width = width;
        }

        public override double CalculateArea()
        {
            return _length*_width;
        }
    }
}
