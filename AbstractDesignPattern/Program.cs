using AbstractDesignPattern.Factory;
using AbstractDesignPattern.Producer;

namespace AbstractDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            FactoryProducer producer0 = new FactoryProducer(new MsSQLDatabase());
            producer0.Start();
            
            
            // FactoryProducer producer1 = new FactoryProducer(new MySQLDatabase());
            // FactoryProducer producer2 = new FactoryProducer(new MongoDatabase());
            // producer1.Start();
            // producer2.Start();

        }
    }
}
