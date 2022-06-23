using _03_StructuralPatterns.Adapter.Example1._1_Interface;
using _03_StructuralPatterns.Adapter.Example1._3_Adapter;
using _03_StructuralPatterns.Adapter.Example2._1_Interface;
using _03_StructuralPatterns.Adapter.Example2._2_Concrete;
using _03_StructuralPatterns.Adapter.Example2._3_Service;
using _03_StructuralPatterns.Adapter.Example2._4_Adapter;
using _03_StructuralPatterns.Decorator.Example1._2_Concrete;
using _03_StructuralPatterns.Decorator.Example1._3_Decorator;
using _03_StructuralPatterns.Decorator.Example1._4_Service;
using _03_StructuralPatterns.Decorator.Example2._1_Abstract;
using _03_StructuralPatterns.Decorator.Example2._2_Concrete;
using _03_StructuralPatterns.Decorator.Example2._3_Decorator.II_Concrete;

#region 3) Structural Patterns

#region I) Adapter

#region Example 1
ICircle circleAdapter = new CircleAdapter3();
Console.WriteLine(circleAdapter.GetArea(2));

Console.WriteLine();

circleAdapter = new CircleAdapterPi();
Console.WriteLine(circleAdapter.GetArea(2));
#endregion

Console.WriteLine();

#region Example 2
ICrypt crypt = new Crypt256();
Console.WriteLine(crypt.Encrypt("Çağıl"));
Console.WriteLine(crypt.Decrypt("Alsaç"));

Console.WriteLine();

crypt = new Crypt512();
Console.WriteLine(crypt.Encrypt("Çağıl"));
Console.WriteLine(crypt.Decrypt("Alsaç"));

Console.WriteLine();

crypt = new MessageAdapter(new MessageService());
Console.WriteLine(crypt.Encrypt("Çağıl"));
Console.WriteLine(crypt.Decrypt("Alsaç"));
#endregion

#endregion

Console.WriteLine();

#region II) Decorator

#region Example 1
OgrenciService ogrenciService = new OgrenciService();
Ogrenci ogrenci = new Ogrenci();
ogrenciService.MezuniyetiGoster(ogrenci);

LisansOgrencisi lisansOgrencisi = new LisansOgrencisi(ogrenci);
ogrenciService.MezuniyetiGoster(lisansOgrencisi, "Ankara Fen Lisesi");

YuksekLisansOgrencisi yuksekLisansOgrencisi = new YuksekLisansOgrencisi(ogrenci);
ogrenciService.MezuniyetiGoster(yuksekLisansOgrencisi, "Ankara Üniversitesi");

YuksekLisansOgrencisi lisansYuksekLisansOgrencisi = new YuksekLisansOgrencisi(new LisansOgrencisi(ogrenci));
ogrenciService.MezuniyetiGoster(lisansYuksekLisansOgrencisi, "9 Eylül Üniversitesi");
Console.WriteLine(lisansYuksekLisansOgrencisi.LiseyiGetir("İzmir Fen Lisesi"));
#endregion

Console.WriteLine();

#region Example 2
CarBase car = new SedanCar("Porsche", "Taycan");
Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Without Discount: " + car.Price);
CarDecorator carDecorator = new CarDecorator(car);
carDecorator.DiscountPercentage = 20;
Console.WriteLine($"Brand: {carDecorator.Brand}, Model: {carDecorator.Model}, With Discount: " + carDecorator.Price);

Console.WriteLine();

car = new SportCar("Porsche", "911", 2000000);
Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Without Discount: " + car.Price);
carDecorator = new CarDecorator(car);
carDecorator.DiscountPercentage = 10;
Console.WriteLine($"Brand: {carDecorator.Brand}, Model: {carDecorator.Model}, With Discount: " + carDecorator.Price);
#endregion

#endregion

#endregion