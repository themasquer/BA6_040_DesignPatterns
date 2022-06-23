using _03_StructuralPatterns.Adapter.Example2._1_Interface;

namespace _03_StructuralPatterns.Adapter.Example2._2_Concrete
{
    public class Crypt256 : ICrypt
    {
        public string Decrypt(string message)
        {
            return $"{message} decrypted over 256 bits.";
        }

        public string Encrypt(string message)
        {
            return $"{message} encrypted over 256 bits.";
        }
    }
}
