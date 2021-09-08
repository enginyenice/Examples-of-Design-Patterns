using FactoryMethodDesignPattern.Interfaces;
using FactoryMethodDesignPattern.Models;

namespace FactoryMethodDesignPattern.Factory
{
    public class TriangleFactory : ICreatorTwo
    {
        public IShape ShapeFactoryMethod()
        {
            return new Triangle();
        }
    }
}