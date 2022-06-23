using _03_StructuralPatterns.Decorator.Example1._1_Interface;

namespace _03_StructuralPatterns.Decorator.Example1._3_Decorator
{
    public class LisansOgrencisi : IOgrenci
    {
        private readonly IOgrenci _ogrenci;

        public LisansOgrencisi(IOgrenci ogrenci) => _ogrenci = ogrenci;

        public string MezuniyetiGetir() => _ogrenci.MezuniyetiGetir() + " Lise Mezunu";
    }
}
