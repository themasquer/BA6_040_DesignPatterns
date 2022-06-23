using _040_DesignPatterns.FactoryMethod.Example2._1_Interface;
using _040_DesignPatterns.FactoryMethod.Example2._2_Concrete;

namespace _040_DesignPatterns.FactoryMethod.Example2._3_Creator
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger() => new FileLogger();
    }
}
