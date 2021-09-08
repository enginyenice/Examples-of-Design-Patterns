using System;
using FactoryMethodDesignPattern.Factory;
using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Example One
            Creator creator = new Creator();
            IShape shape = creator.ShapeFactoryMethod(FactoryEnum.Circle);
            shape.Draw();

            shape = creator.ShapeFactoryMethod(FactoryEnum.Square);
            shape.Draw();

            shape = creator.ShapeFactoryMethod(FactoryEnum.Triangle);
            shape.Draw();

            System.Console.WriteLine("---------------");

            // Example Two
            ICreatorTwo[] creatorTwo = {
                new CircleFactory(),
                new SquareFactory(),
                new TriangleFactory()
            };
            foreach (ICreatorTwo factoryItem in creatorTwo)
            {
                IShape shape1 = factoryItem.ShapeFactoryMethod();
                shape1.Draw();
            }

        }
    }
}
