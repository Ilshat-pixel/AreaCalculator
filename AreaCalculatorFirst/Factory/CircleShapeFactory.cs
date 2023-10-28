using AreaCalculatorFirst.Domain;

namespace AreaCalculatorFirst.Factory
{
    public class CircleShapeFactory : ShapeFactory
    {
        private readonly double[] _properties;

        public CircleShapeFactory(double[] properties)
        {
            _properties = properties;
        }

        public override IShape GetShape()
        {
            if (_properties.Length != 1) throw new ArgumentException("Circle must have only one property (radius)");
            if (_properties[0] <= 0) throw new ArgumentException("Radius must me more then 0");

            var area = Math.PI * _properties[0] * _properties[0];

            Circle circle = new(area, _properties[0]);

            return circle;
        }
    }
}
