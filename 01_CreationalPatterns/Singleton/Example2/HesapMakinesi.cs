namespace _040_DesignPatterns.Singleton.Example2
{
    public class HesapMakinesi
    {
        private static HesapMakinesi _hesapMakinesi;

        private HesapMakinesi()
        {

        }

        public static HesapMakinesi HesapMakinesiOlustur()
        {
            if (_hesapMakinesi == null)
                _hesapMakinesi = new HesapMakinesi();
            return _hesapMakinesi;
        }

        public double Topla(double sayi1, double sayi2) => sayi1 + sayi2;
        public double Cikar(double sayi1, double sayi2) => sayi1 - sayi2;
        public double Carp(double sayi1, double sayi2) => sayi1 * sayi2;
        public double Bol(double sayi1, double sayi2) => sayi1 / sayi2;
    }
}
