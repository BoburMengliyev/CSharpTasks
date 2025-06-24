// ####################################
// Task 1

//using HomeTask16.Task1;

//Student student = new Student(15);
//student.Greet();
//student.Greet();
//student.ShowAge();
//student.Study();
//student.Greet();
//Teacher teacher = new Teacher(15);
//teacher.Explain();

// ####################################
// Task 2

//using HomeTask16.Task2;

//Shape shape = new Shape("Red");
//Rectangle rectangle = new Rectangle(5.6, 10.9, "Blue");
//Circle circle = new Circle(6.5, "Black");

// ####################################
// Task 3

// === Lamp qurilmasi ===
using HomeTask16.Task3;
using Lock = HomeTask16.Task3.Lock;

Lamp lamp = new Lamp();
lamp.TurnOn();
lamp.SetBrightness(75);
lamp.ChangeColor("Yashil");
lamp.TurnOff();
Console.WriteLine();

// === Thermostat qurilmasi ===
Thermostat thermostat = new Thermostat();
thermostat.TurnOn();
thermostat.SetTemperature(23.5);
thermostat.TargetTemperature = 25;
thermostat.GetStatus();
thermostat.TurnOff();
Console.WriteLine();

// === Lock qurilmasi ===
Lock smartLock = new Lock();
smartLock.TurnOn();      // Ochish
smartLock.GetStatus();
smartLock.TurnOff();     // Qulflash
smartLock.GetStatus();