using _02_BehavioralPatterns.Mediator.Example1._1_Interface;
using _02_BehavioralPatterns.Mediator.Example1._3_Mediator._1_Interface;

namespace _02_BehavioralPatterns.Mediator.Example1._2_Concrete
{
    public class BasicUser : IUser
    {
        private readonly IChatMediator _chatMediator;

        private readonly string _userName;

        public BasicUser(IChatMediator chatMediator, string userName)
        {
            _chatMediator = chatMediator;
            _userName = userName;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"User Type: Basic\nUser Name: {_userName}\nReceived Message: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
