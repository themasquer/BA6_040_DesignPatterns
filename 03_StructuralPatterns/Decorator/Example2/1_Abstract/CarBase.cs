namespace _03_StructuralPatterns.Decorator.Example2._1_Abstract
{
    public abstract class CarBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public abstract double Price { get; set; }

        protected CarBase(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
