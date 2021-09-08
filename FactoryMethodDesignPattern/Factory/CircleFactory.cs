using FactoryMethodDesignPattern.Interfaces;
using FactoryMethodDesignPattern.Models;

namespace FactoryMethodDesignPattern.Factory
{
    public class CircleFactory : ICreatorTwo
    {
        public IShape ShapeFactoryMethod()
        {
            return new Circle();
        }
    }
}