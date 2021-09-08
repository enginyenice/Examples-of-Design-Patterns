using AbstractDesignPattern.Interfaces;

namespace AbstractDesignPattern.Producer
{
    public class FactoryProducer
    {
        private readonly DatabaseFactory _databaseFactory;
        private readonly IDatabase _database;
        private readonly ICommand _command;

        public FactoryProducer(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _database = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();
        }
        public void Start(){
            _database.Connection();
            _command.Execute("Database Query");
        }


    }
}