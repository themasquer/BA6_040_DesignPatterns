using _03_StructuralPatterns.Decorator.Example2._1_Abstract;

namespace _03_StructuralPatterns.Decorator.Example2._3_Decorator.I_Abstract
{
    public abstract class CarDecoratorBase : CarBase
    {
        protected readonly CarBase _carBase;

        protected CarDecoratorBase(CarBase carBase) : base(carBase.Brand, carBase.Model) => _carBase = carBase;
    }
}
