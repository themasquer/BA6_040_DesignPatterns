using _02_BehavioralPatterns.Mediator.Example1._1_Interface;
using _02_BehavioralPatterns.Mediator.Example1._3_Mediator._1_Interface;

namespace _02_BehavioralPatterns.Mediator.Example1._2_Concrete
{
    public class GoldUser : IUser
    {
        private readonly IChatMediator _chatMediator;

        private readonly string _userName;

        public GoldUser(IChatMediator chatMediator, string userName)
        {
            _chatMediator = chatMediator;
            _userName = userName;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"User Type: Gold\nUser Name: {_userName}\nReceived Message: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
