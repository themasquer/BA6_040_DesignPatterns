using _03_StructuralPatterns.Adapter.Example2._1_Interface;
using _03_StructuralPatterns.Adapter.Example2._3_Service;

namespace _03_StructuralPatterns.Adapter.Example2._4_Adapter
{
    public class MessageAdapter : ICrypt
    {
        private readonly MessageService _messageService;

        public MessageAdapter(MessageService messageService)
        {
            _messageService = messageService;
        }

        public string Decrypt(string message)
        {
            return _messageService.DecryptMessage(message);
        }

        public string Encrypt(string message)
        {
            return _messageService.EncryptMessage(message);
        }
    }
}
