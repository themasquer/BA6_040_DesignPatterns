using _03_StructuralPatterns.Decorator.Example1._1_Interface;

namespace _03_StructuralPatterns.Decorator.Example1._4_Service
{
    public class OgrenciService
    {
        public void MezuniyetiGoster(IOgrenci ogrenci, string okul = "") => Console.WriteLine(ogrenci.MezuniyetiGetir() + " " + okul);
    }
}
