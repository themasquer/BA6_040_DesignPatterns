using _03_StructuralPatterns.Adapter.Example1._1_Interface;
using _03_StructuralPatterns.Adapter.Example1._2_Concrete;

namespace _03_StructuralPatterns.Adapter.Example1._3_Adapter
{
    public class CircleAdapterPi : Circle, ICircle
    {
        public double GetArea(double radius)
        {
            return CalculateArea(radius, Math.PI);
        }
    }
}
