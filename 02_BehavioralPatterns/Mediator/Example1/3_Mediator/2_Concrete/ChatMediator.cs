using _02_BehavioralPatterns.Mediator.Example1._1_Interface;
using _02_BehavioralPatterns.Mediator.Example1._3_Mediator._1_Interface;

namespace _02_BehavioralPatterns.Mediator.Example1._3_Mediator._2_Concrete
{
    public class ChatMediator : IChatMediator
    {
        private List<IUser> _users;

        public ChatMediator()
        {
            _users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, IUser sendingUser)
        {
            foreach (IUser _user in _users)
            {
                if (_user != sendingUser)
                {
                    _user.ReceiveMessage(message);
                }
            }
        }
    }
}
