using AbstractDesignPattern.Command;
using AbstractDesignPattern.Database;
using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Factory
{
    public class MsSQLDatabase : DatabaseFactory
    {
        public override ICommand CreateCommand()
        {
            return new MsSQLCommand();
        }

        public override IDatabase CreateConnection()
        {
            return new MsSQL();
        }
    }
}