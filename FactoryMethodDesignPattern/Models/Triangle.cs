using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Models
{
    public class Triangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Triangle::Draw");
        }
    }
}