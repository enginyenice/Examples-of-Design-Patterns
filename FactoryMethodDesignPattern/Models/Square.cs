using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Models
{
    public class Square : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Square::Draw");
        }
    }
}