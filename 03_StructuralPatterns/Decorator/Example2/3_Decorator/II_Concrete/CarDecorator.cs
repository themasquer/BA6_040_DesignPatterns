using _03_StructuralPatterns.Decorator.Example2._1_Abstract;
using _03_StructuralPatterns.Decorator.Example2._3_Decorator.I_Abstract;

namespace _03_StructuralPatterns.Decorator.Example2._3_Decorator.II_Concrete
{
    public class CarDecorator : CarDecoratorBase
    {
        public CarDecorator(CarBase carBase) : base(carBase)
        {

        }

        public double DiscountPercentage { get; set; }

        public override double Price
        {
            get
            {
                return DiscountPercentage != 0 ? _carBase.Price - (_carBase.Price * DiscountPercentage / 100) : _carBase.Price;
            }
            set
            {
                _carBase.Price = value;
            }
        }
    }
}
