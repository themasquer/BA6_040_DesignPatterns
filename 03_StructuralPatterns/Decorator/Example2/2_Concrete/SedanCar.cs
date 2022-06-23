using _03_StructuralPatterns.Decorator.Example2._1_Abstract;

namespace _03_StructuralPatterns.Decorator.Example2._2_Concrete
{
    public class SedanCar : CarBase
    {
        public override double Price { get; set; }

        public SedanCar(string brand, string model, double price = 500000) : base(brand, model)
        {
            Price = price;
        }
    }
}
