using _040_DesignPatterns.FactoryMethod.Example2._1_Interface;

namespace _040_DesignPatterns.FactoryMethod.Example2._2_Concrete
{
    public class FileLogger : ILogger
    {
        public void Log() => Console.WriteLine("Logged to file");
    }
}
