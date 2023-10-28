using AreaCalculatorFirst.Domain;
using AreaCalculatorFirst.Factory;

namespace AreaCalculatorFirst.Facade
{
    public static class ShapeFactoryFacade
    {
        public static IShape GetFactory(params double[] properties) =>
            properties.Length switch
            {
                1 => new CircleShapeFactory(properties).GetShape(),
                3 => new TriangleFactory(properties).GetShape(),
                _ => throw new ArgumentException()
            };
    }
}
