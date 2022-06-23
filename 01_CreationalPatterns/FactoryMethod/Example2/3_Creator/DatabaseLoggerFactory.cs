using _040_DesignPatterns.FactoryMethod.Example2._1_Interface;
using _040_DesignPatterns.FactoryMethod.Example2._2_Concrete;

namespace _040_DesignPatterns.FactoryMethod.Example2._3_Creator
{
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger() => new DatabaseLogger();
    }
}
