namespace AreaCalculatorFirst.Domain
{
    public class Circle : IShape
    {
        private readonly double _area;
        private readonly double _radius;

        public Circle(double area, double radius)
        {
            _area = area;
            _radius = radius;
        }

        public double Radius => _radius;
        public double GetArea() => _area;
    }
}
