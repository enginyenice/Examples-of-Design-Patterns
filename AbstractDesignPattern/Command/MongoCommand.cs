using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Command
{
    public class MongoCommand : ICommand
    {
        public void Execute(string query)
        {
            System.Console.WriteLine("Mongo Command : \"{0}\" executed.",query);
        }
    }
}