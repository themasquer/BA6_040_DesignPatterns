using _040_DesignPatterns.FactoryMethod.Example1._1_Interface;
using _040_DesignPatterns.FactoryMethod.Example1._2_Concrete;

namespace _040_DesignPatterns.FactoryMethod.Example1._3_Creator
{
    public class ProductCreator
    {
        public IProduct FactoryMethod(int month)
        {
            if (month >= 1 && month <= 5)
                return new Computer();
            else if (month >= 6 && month <= 10)
                return new Phone();
            else
                return new DefaultProduct();
        }
    }
}
