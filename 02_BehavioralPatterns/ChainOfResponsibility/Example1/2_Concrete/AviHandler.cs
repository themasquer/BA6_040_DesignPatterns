using _02_BehavioralPatterns.ChainOfResponsibility.Example1._1_Abstract;

namespace _02_BehavioralPatterns.ChainOfResponsibility.Example1._2_Concrete
{
    public class AviHandler : PlayerHandlerBase
    {
        public override void Play(string file)
        {
            if (file.EndsWith(".avi"))
                Console.WriteLine($"{file} is playing.");
            else
                Console.WriteLine("Invalid file!");
        }
    }
}
