namespace _040_DesignPatterns.Singleton.Example1
{
    public class LogService
    {
        private static LogService _logService;

        private LogService() // buradaki amaç bu sınıfın dışarıdan erişilerek new'lenmesini engellemektir
        {

        }

        // nesneyi sınıfın kendi içerisinde kontrollü bir şekilde custom bir method yada propety üzerinden üretiyoruz
        public static LogService CreateLogService() // dışarıdan LogService.CreateLogService() methodu çağrılarak eğer obje yoksa uygulama boyunca tek bir instance olacak şekilde objeyi oluşturur ya da mevcut olan tek objeyi geri döner
        {
            if (_logService == null)
                _logService = new LogService();
            return _logService;
        }

        public void Log() => Console.WriteLine("Logged");
    }
}
