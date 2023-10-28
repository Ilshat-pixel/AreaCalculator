using AreaCalculatorFirst.Facade;

namespace AreaCalculator.Test
{
    public class CircleShapeFactoryTest
    {

        [Fact]
        public void GetShape_WithPropertiesLessOrEqualZero_ShoudThrowArgumentException()
        {
            var properties = new double[] { 0 };

            Assert.Throws<ArgumentException>(() => ShapeFactoryFacade.GetFactory(properties));
        }

        [Fact]
        public void GetShape_WithPropertiesLenghtNotEqualOne_ShoudThrowArgumentException()
        {
            var properties = new double[] { 0, 2 };

            Assert.Throws<ArgumentException>(() => ShapeFactoryFacade.GetFactory(properties));
        }

        [Fact]
        public void GetShape_WithRadiusOne_ShoudEqualMathPi()
        {
            var properties = new double[] { 1 };

            var circleFactory = ShapeFactoryFacade.GetFactory(properties);

            Assert.Equal(Math.PI, circleFactory.GetArea());
        }

    }
}
