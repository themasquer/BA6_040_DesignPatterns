using _040_DesignPatterns.FactoryMethod.Example1._1_Interface;

namespace _040_DesignPatterns.FactoryMethod.Example1._2_Concrete
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom() => "No shipping";
    }
}
