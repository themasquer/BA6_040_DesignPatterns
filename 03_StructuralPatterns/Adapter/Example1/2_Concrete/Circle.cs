namespace _03_StructuralPatterns.Adapter.Example1._2_Concrete
{
    public class Circle
    {
        public double CalculateArea(double radius, double pi) => pi * Math.Pow(radius, 2);
    }
}
