using _040_DesignPatterns.FactoryMethod.Example1._1_Interface;
using _040_DesignPatterns.FactoryMethod.Example1._3_Creator;
using _040_DesignPatterns.FactoryMethod.Example2._3_Creator;
using _040_DesignPatterns.FactoryMethod.Example2._4_Service.ConstructorInjection;
using _040_DesignPatterns.FactoryMethod.Example2._4_Service.MethodInjection;
using _040_DesignPatterns.FactoryMethod.Example2._4_Service.PropertyInjection;
using _040_DesignPatterns.Singleton.Example1;
using _040_DesignPatterns.Singleton.Example2;

#region 1) Creational Patterns

#region I) Factory Method

#region Example 1
ProductCreator productCreator = new ProductCreator();
IProduct product;
for (int month = 1; month <= 12; month++)
{
    product = productCreator.FactoryMethod(month);
    Console.WriteLine($"Products: {product.ShipFrom()}");
}
#endregion

Console.WriteLine();

#region Example 2
// Dependency Injection Yöntemleri:
// 1. Constructor Injection: İlgili sınıf (service) initialize edildiğinde objesi enjekte edilecek sınıfı (loggerFactory) constructor'a parametre olarak vermemiz gerekmektedir.
// Genelde Constructor Injection tercih edilir.
// 2. Method Injection: İlgili sınıf (service) initialize edildikten sonra ihtiyaç olan method çağrılarak objesi enjekte edilecek sınıfı (loggerFactory) method'a parametre olarak vermemiz gerekmektedir.
// Bu yöntemle sadece service sınıfındaki belli bir method için enjekte edilen obje (loggerFactory) üzerinden gereken işlemin yapılması sağlanır.
// 3. Property Injection: İlgili sınıf (service) initialize edilirken objesi enjekte edilecek sınıfı (loggerFactory) servis sınıfının özelliği üzerinden atamamız gerekmektedir.

// constructor injection
//ProductService productService = new ProductService(new DatabaseLoggerFactory());
ProductService productService = new ProductService(new FileLoggerFactory());
productService.AddProduct();

// method injection
CategoryService categoryService = new CategoryService();
//categoryService.AddCategory(new DatabaseLoggerFactory());
categoryService.AddCategory(new FileLoggerFactory());

// property injection
StoreService storeService = new StoreService()
{
    //LoggerFactory = new DatabaseLoggerFactory()
    LoggerFactory = new FileLoggerFactory()
};
storeService.AddStore();
#endregion

#endregion

Console.WriteLine();

#region II) Singleton

#region Example 1
//LogService logService = new LogService(); // izin vermez çünkü LogService class'ında constructor private
LogService logService = LogService.CreateLogService(); // LogService class'ının objeyi dönen CreateLogService() methodunu çağırıyoruz ki uygulama boyunca elimizde tek bir obje olsun
logService.Log();
#endregion

Console.WriteLine();

#region Example 2
HesapMakinesi hesapMakinesi = HesapMakinesi.HesapMakinesiOlustur();
Console.WriteLine($"Toplam: {hesapMakinesi.Topla(1, 2)}");
Console.WriteLine($"Fark: {hesapMakinesi.Cikar(4, 3)}");
Console.WriteLine($"Çarpım: {hesapMakinesi.Carp(5, 6)}");
Console.WriteLine($"Bölüm: {hesapMakinesi.Bol(6, 2)}");
#endregion

#endregion

#endregion