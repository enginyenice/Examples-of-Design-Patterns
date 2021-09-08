using AbstractDesignPattern.Command;
using AbstractDesignPattern.Database;
using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Factory
{
    public class MySQLDatabase : DatabaseFactory
    {
        public override ICommand CreateCommand()
        {
            return new MySQLCommand();
        }

        public override IDatabase CreateConnection()
        {
            return new MySQL();
        }
    }
}