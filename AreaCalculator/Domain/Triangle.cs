namespace AreaCalculatorFirst.Domain
{
    public class Triangle : IShape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;
        private readonly bool _isRightAngle;
        private readonly double _area;

        public Triangle(double firstSide, double secondSide, double thirdSide, bool isRightAngle, double area)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
            _isRightAngle = isRightAngle;
            _area = area;
        }

        public bool IsRightAngle => _isRightAngle;
        public double FirstSide => _firstSide;
        public double SecondSide => _secondSide;
        public double ThirdSide => _thirdSide;

        public double GetArea() => _area;
    }
}
