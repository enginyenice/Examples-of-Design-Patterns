using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Database
{
    public class MsSQL : IDatabase
    {
        public bool Connection()
        {
            System.Console.WriteLine("MsSQL Connection");
            return true;
        }
    }
}