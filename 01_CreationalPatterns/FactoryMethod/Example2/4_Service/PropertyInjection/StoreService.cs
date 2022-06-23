using _040_DesignPatterns.FactoryMethod.Example2._1_Interface;

namespace _040_DesignPatterns.FactoryMethod.Example2._4_Service.PropertyInjection
{
    // property injection
    public class StoreService
    {
        public ILoggerFactory LoggerFactory { get; set; }

        public void AddStore()
        {
            Console.WriteLine("Store added");
            LoggerFactory.CreateLogger().Log();
        }
    }
}
