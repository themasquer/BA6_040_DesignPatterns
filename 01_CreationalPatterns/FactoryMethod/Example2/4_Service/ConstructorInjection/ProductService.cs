using _040_DesignPatterns.FactoryMethod.Example2._1_Interface;

namespace _040_DesignPatterns.FactoryMethod.Example2._4_Service.ConstructorInjection
{
    // constructor injection
    public class ProductService 
    {
        private readonly ILoggerFactory _loggerFactory;

        public ProductService(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void AddProduct()
        {
            Console.WriteLine("Product added");
            _loggerFactory.CreateLogger().Log();
        }
    }
}
