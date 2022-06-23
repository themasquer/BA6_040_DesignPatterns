using _040_DesignPatterns.FactoryMethod.Example2._1_Interface;

namespace _040_DesignPatterns.FactoryMethod.Example2._4_Service.MethodInjection
{
    // method injection
    public class CategoryService
    {
        public void AddCategory(ILoggerFactory loggerFactory)
        {
            Console.WriteLine("Category added");
            loggerFactory.CreateLogger().Log();
        }
    }
}
