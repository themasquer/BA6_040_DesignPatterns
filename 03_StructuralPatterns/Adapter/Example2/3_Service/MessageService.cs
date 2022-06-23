namespace _03_StructuralPatterns.Adapter.Example2._3_Service
{
    public class MessageService
    {
        public string DecryptMessage(string message)
        {
            return $"{message} decrypted by service.";
        }

        public string EncryptMessage(string message)
        {
            return $"{message} encrypted by service.";
        }
    }
}
