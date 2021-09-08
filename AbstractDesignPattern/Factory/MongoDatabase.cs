using AbstractDesignPattern.Command;
using AbstractDesignPattern.Database;
using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Factory
{
    public class MongoDatabase : DatabaseFactory
    {
        public override ICommand CreateCommand()
        {
            return new MongoCommand();
        }

        public override IDatabase CreateConnection()
        {
            return new Mongo();
        }
    }
}