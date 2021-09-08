using FactoryMethodDesignPattern.Interfaces;
using FactoryMethodDesignPattern.Models;

namespace FactoryMethodDesignPattern.Factory
{
    public class Creator : ICreator
    {
        public IShape ShapeFactoryMethod(FactoryEnum factory)
        {
            IShape shape = null;
            switch (factory)
            {
                case FactoryEnum.Circle:
                    shape = new Circle();
                    break;
                case FactoryEnum.Square:
                    shape = new Square();
                    break;
                case FactoryEnum.Triangle:
                    shape = new Triangle();
                    break;
                default:
                    break;
            }

            return shape;
        }
    }
}