using AreaCalculatorFirst.Domain;
using AreaCalculatorFirst.Facade;

namespace AreaCalculator.Test
{
    public class TriangleShapeFactoryTest
    {
        [Fact]
        public void GetShape_WithPropertiesLessOrEqualZero_ShoudThrowArgumentException()
        {
            var properties = new double[] { 0 };

            Assert.Throws<ArgumentException>(() => ShapeFactoryFacade.GetFactory(properties));
        }

        [Fact]
        public void GetShape_WithPropertiesLenghtNotEqualThree_ShoudThrowArgumentException()
        {
            var properties = new double[] { 0, 2 };

            Assert.Throws<ArgumentException>(() => ShapeFactoryFacade.GetFactory(properties));
        }

        [Fact]
        public void GetShape_RightTriangleSide_ShoudBeRightTriangleWithAreaEqualSix()
        {
            var properties = new double[] { 3,4,5 };

            var trianleFactory = ShapeFactoryFacade.GetFactory(properties);
            var triangle = trianleFactory as Triangle;

            Assert.Equal(6, trianleFactory.GetArea());
            Assert.True(triangle!.IsRightAngle);
        }

        [Fact]
        public void GetShape_UncorrectTriangleSide_ShoudThrowArgumentException()
        {
            var properties = new double[] { 3, 4, 1 };

            Assert.Throws<ArgumentException>(() => ShapeFactoryFacade.GetFactory(properties));
        }
    }
}
