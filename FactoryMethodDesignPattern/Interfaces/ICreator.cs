using FactoryMethodDesignPattern.Factory;

namespace FactoryMethodDesignPattern.Interfaces
{
    public interface ICreator
    {
        IShape ShapeFactoryMethod(FactoryEnum factory);
    }
}