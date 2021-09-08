using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Database
{
    public class Mongo : IDatabase
    {
        public bool Connection()
        {
            System.Console.WriteLine("MongoDb Connection");
            return true;
        }
    }
}