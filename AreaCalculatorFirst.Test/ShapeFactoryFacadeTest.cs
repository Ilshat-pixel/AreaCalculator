using AreaCalculatorFirst.Domain;
using AreaCalculatorFirst.Facade;

namespace AreaCalculatorFirst.Test
{
    public class ShapeFactoryFacadeTest
    {

        [Fact]
        public void GetFactory_WithThreeCorrectProperties_ShoudReturnTriangleFactory()
        {
            var properties = new double[] { 3, 4, 5 };

            var factory = ShapeFactoryFacade.GetFactory(properties);

            Assert.IsType<Triangle>(factory);
        }

        [Fact]
        public void GetFactory_WithOneCorrectProperty_ShoudReturnCircleFactory()
        {
            var properties = new double[] { 3 };

            var factory = ShapeFactoryFacade.GetFactory(properties);

            Assert.IsType<Circle>(factory);
        }

        [Fact]
        public void GetFactory_WithUncorrectProperty_ShoudThrowArgumentException()
        {
            var properties = new double[] { 1,2,3,4,5,6,7,8,9,10 };

            Assert.Throws<ArgumentException>(() => ShapeFactoryFacade.GetFactory(properties));
        }


    }
}
