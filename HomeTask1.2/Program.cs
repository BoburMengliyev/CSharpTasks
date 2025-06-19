// ################################################
// ## Task 1

//using HomeTask12.ClassesOne;

//Laptop laptop = new Laptop("Lenavo", "Ryzen 5", 16, 8);
//laptop.Start();
//laptop.DisplayInfo();
//laptop.Charge();

//SmartPhone phone = new SmartPhone("Samsung", "Snapdragon 8", 8, 108);
//phone.Start();
//phone.DisplayInfo();
//phone.TakePhoto();

// ################################################
// ## Task 2

using HomeTask12.ClassesTwo;

PassengerCar yengilAvtomobil = new PassengerCar("Toyota", 5, 120.5, 2001, 6);
yengilAvtomobil.GetInfo();
Console.WriteLine();

CargoCar yukMashina = new CargoCar("Volvo Yuk Mashinasi", 2, 120.8, 2005, 8);
yukMashina.GetInfo();
Console.WriteLine();

PassengerPlane yolovchiSam = new PassengerPlane("Boing 123", 180, 320.0, 2011, 5);
yolovchiSam.GetInfo();
Console.WriteLine();

CargoPlane yukSam = new CargoPlane("absd 123", 200, 200, 2006, 120000);
yolovchiSam.GetInfo();
Console.WriteLine();

Train poyezd = new Train("Afrosyob", 500, 200, 2007, 8);
poyezd.GetInfo();
Console.WriteLine();