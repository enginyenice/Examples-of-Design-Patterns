using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Database
{
    public class MySQL : IDatabase
    {
        public bool Connection()
        {
            System.Console.WriteLine("MySQL Connection");
            return true;
        }
    }
}