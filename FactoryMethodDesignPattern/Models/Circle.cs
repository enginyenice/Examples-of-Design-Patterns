using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Models
{
    public class Circle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Circle::Draw");
        }
    }
}