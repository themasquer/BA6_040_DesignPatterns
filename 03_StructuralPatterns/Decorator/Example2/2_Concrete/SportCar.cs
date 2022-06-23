using _03_StructuralPatterns.Decorator.Example2._1_Abstract;

namespace _03_StructuralPatterns.Decorator.Example2._2_Concrete
{
    public class SportCar : CarBase
    {
        public override double Price { get; set; }

        public SportCar(string brand, string model, double price = 1000000) : base(brand, model)
        {
            Price = price;
        }
    }
}
