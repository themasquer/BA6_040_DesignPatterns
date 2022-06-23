using _040_DesignPatterns.FactoryMethod.Example1._1_Interface;

namespace _040_DesignPatterns.FactoryMethod.Example1._2_Concrete
{
    public class Computer : IProduct
    {
        public string ShipFrom() => "Computers ship from United States";
    }
}
