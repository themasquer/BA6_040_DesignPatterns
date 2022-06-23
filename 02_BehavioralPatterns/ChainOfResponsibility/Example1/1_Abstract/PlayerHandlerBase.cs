namespace _02_BehavioralPatterns.ChainOfResponsibility.Example1._1_Abstract
{
    public abstract class PlayerHandlerBase
    {
        protected PlayerHandlerBase _nextPlayerHandler;

        public PlayerHandlerBase NextPlayerHandler { set => _nextPlayerHandler = value; }

        public abstract void Play(string file);
    }
}
