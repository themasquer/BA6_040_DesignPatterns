using _02_BehavioralPatterns.ChainOfResponsibility.Example1._1_Abstract;

namespace _02_BehavioralPatterns.ChainOfResponsibility.Example1._2_Concrete
{
    public class Mp4Handler : PlayerHandlerBase
    {
        public override void Play(string file)
        {
            if (file.EndsWith(".mp4"))
            {
                Console.WriteLine($"{file} is playing.");
            }
            else
            {
                if (_nextPlayerHandler != null)
                {
                    _nextPlayerHandler.Play(file);
                }
            }
        }
    }
}
