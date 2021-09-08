using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Command
{
    public class MySQLCommand : ICommand
    {
        public void Execute(string query)
        {
            System.Console.WriteLine("MySQL Command : \"{0}\" executed.",query);
        }
    }
}