namespace AbstractDesignPattern.Interfaces
{
    public abstract class DatabaseFactory
    {
        public abstract IDatabase CreateConnection();
        public abstract ICommand CreateCommand();
    }
}