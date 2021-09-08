using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Command
{
    public class MsSQLCommand : ICommand
    {
        public void Execute(string query)
        {
            System.Console.WriteLine("MsSQL Command : \"{0}\" executed.",query);
        }
    }
}