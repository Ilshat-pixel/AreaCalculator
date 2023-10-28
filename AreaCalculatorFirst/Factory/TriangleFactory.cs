using AreaCalculatorFirst.Domain;

namespace AreaCalculatorFirst.Factory
{
    public class TriangleFactory : ShapeFactory
    {
        private readonly double[] _properties;

        public TriangleFactory(double[] properties)
        {
            _properties = properties;
        }

        public override IShape GetShape()
        {
            if (_properties.Length != 3) throw new ArgumentException("Triangle must have three side");
            if (_properties.Any(p => p <= 0)) throw new ArgumentException("Any side must me more then 0");
            if(!IsValidTriangle(_properties)) throw new ArgumentException($"Triangle with this sides cannot narrow");

            var isRightAngle = IsRightAngle(_properties);
            var area = GetTriangleArea(_properties[0], _properties[1], _properties[2]);

            Triangle triangle = new(_properties[0], _properties[1], _properties[2], isRightAngle, area);

            return triangle;
        }

        private bool IsValidTriangle(double[] sides) 
                => sides[0] + sides[1] > sides[2]
                && sides[1] + sides[2] > sides[0]
                && sides[2] + sides[0] > sides[1];

        private bool IsRightAngle(double[] sides) 
                => (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2]) ||
                   (sides[1] * sides[1] + sides[2] * sides[2] == sides[0] * sides[0]) ||
                   (sides[0] * sides[0] + sides[2] * sides[2] == sides[1] * sides[1]);

        private  double GetTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

    }
}
