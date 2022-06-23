using _02_BehavioralPatterns.Mediator.Example1._1_Interface;

namespace _02_BehavioralPatterns.Mediator.Example1._3_Mediator._1_Interface
{
    public interface IChatMediator
    {
        void AddUser(IUser user);

        void SendMessage(string message, IUser sendingUser);
    }
}
