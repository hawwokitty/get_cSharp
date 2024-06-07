namespace Formkontrollsystem
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract double CalculateArea();
    }
}
