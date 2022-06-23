using _03_StructuralPatterns.Decorator.Example1._1_Interface;

namespace _03_StructuralPatterns.Decorator.Example1._3_Decorator
{
    public class YuksekLisansOgrencisi : IOgrenci
    {
        private readonly IOgrenci _ogrenci;

        public YuksekLisansOgrencisi(IOgrenci ogrenci) => _ogrenci = ogrenci;

        public string MezuniyetiGetir() => _ogrenci.MezuniyetiGetir() + " Lisans Mezunu";

        public string LiseyiGetir(string lise) => "(Lise: " + lise + ")";
    }
}
