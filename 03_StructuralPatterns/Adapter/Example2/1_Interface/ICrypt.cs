namespace _03_StructuralPatterns.Adapter.Example2._1_Interface
{
    public interface ICrypt
    {
        string Encrypt(string message);
        string Decrypt(string message);
    }
}
