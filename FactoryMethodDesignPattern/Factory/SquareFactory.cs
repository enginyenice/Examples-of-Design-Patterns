using FactoryMethodDesignPattern.Interfaces;
using FactoryMethodDesignPattern.Models;

namespace FactoryMethodDesignPattern.Factory
{
    public class SquareFactory : ICreatorTwo
    {
        public IShape ShapeFactoryMethod()
        {
            return new Square();
        }
    }
}