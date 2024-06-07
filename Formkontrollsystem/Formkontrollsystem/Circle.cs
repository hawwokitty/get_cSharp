namespace Formkontrollsystem
{
    internal class Circle : Shape
    {
        private double _radius {  get; set; }
        public Circle(string name, string color, double radius)
        {
            Name = name;
            Color = color;
            _radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
