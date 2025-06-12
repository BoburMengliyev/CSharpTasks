// #################################################################
// ### Task 1

//using System;

//class Person 
//{
//    public string FirstName; 
//    public string LastName; 
//    public int Age; 
//    public string Address;

//    public string GetFullName()
//    {
//        return FirstName + " " + LastName;
//    }

//    public int GetBirthYear()
//    {
//        return DateTime.Now.Year - Age;
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person person = new Person();
//        person.FirstName = "Bobur";
//        person.LastName = "Mengliyev";
//        person.Age = 24;
//        person.Address = "Tashkent";
//        Console.WriteLine("Full Name: " + person.GetFullName());
//        Console.WriteLine("Birth Year: " + person.GetBirthYear());
//    }
//}

// #################################################################
// ### Task 2

//using System;

//class Rectangle
//{
//    public double Width;
//    public double Height;

//    public double GetArea()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Rectangle rectangle = new Rectangle();
//        rectangle.Width = 7.0;
//        rectangle.Height = 5.0;
//        Console.WriteLine("Area of the rectangle: " + rectangle.GetArea());
//    }
//}

// #################################################################
// ### Task 3

//using System;

//class Student
//{
//    public string Name;
//    public int GradeLevel;
//    public int[] Scores;

//    public double GetAverage()
//    {
//        if (Scores.Length == 0) return 0;

//        int total = 0;
//        foreach (int score in Scores)
//        {
//            total += score;
//        }

//        return (double)total / Scores.Length;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student[] students = new Student[5];

//        students[0] = new Student { Name = "Ali", GradeLevel = 10, Scores = new int[] { 90, 85, 88, 92, 87 } };
//        students[1] = new Student { Name = "Laylo", GradeLevel = 9, Scores = new int[] { 72, 68, 75, 70, 69 } };
//        students[2] = new Student { Name = "Rustam", GradeLevel = 11, Scores = new int[] { 65, 60, 58, 62, 67 } };
//        students[3] = new Student { Name = "Dildora", GradeLevel = 8, Scores = new int[] { 78, 80, 76, 74, 79 } };
//        students[4] = new Student { Name = "Jasur", GradeLevel = 10, Scores = new int[] { 95, 93, 97, 96, 94 } };

//        foreach (Student student in students)
//        {
//            double avg = student.GetAverage();
//            Console.WriteLine($"Student: {student.Name} (Grade {student.GradeLevel})");
//            Console.WriteLine($"Average Score: {avg:F2}");

//            if (avg > 85)
//            {
//                Console.WriteLine("Great job! Keep up the excellent work!\n");
//            }
//            else if (avg < 70)
//            {
//                Console.WriteLine("Don't give up! Consider seeking help and keep trying.\n");
//            }
//            else
//            {
//                Console.WriteLine("You're doing well, keep pushing to improve even more!\n");
//            }
//        }
//    }
//}

// #################################################################
// ### Task 4

//using System;

//class Car
//{
//    public string Make;
//    public string Model;
//    public int Year;
//    public double Mileage;
//    public double Fuel;

//    public Car(string make, string model, int year)
//    {
//        Make = make;
//        Model = model;
//        Year = year;
//        Mileage = 0.0;
//        Fuel = 0.0;
//    }

//    public void Drive(double miles)
//    {
//        const double milesPerGallon = 25.0;

//        double fuelNeeded = miles / milesPerGallon;

//        if (fuelNeeded > Fuel)
//        {
//            Console.WriteLine("Not enough fuel to drive that far. Please refuel.");
//        }
//        else
//        {
//            Fuel -= fuelNeeded;
//            Mileage += miles;
//            Console.WriteLine($"You drove {miles} miles. Remaining fuel: {Fuel:F2} gallons. Total mileage: {Mileage:F2} miles.");
//        }
//    }

//    public void AddFuel(double gallons)
//    {
//        if (gallons <= 0)
//        {
//            Console.WriteLine("Please add a positive amount of fuel.");
//        }
//        else
//        {
//            Fuel += gallons;
//            Console.WriteLine($"Added {gallons} gallons of fuel. Current fuel level: {Fuel:F2} gallons.");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car myCar = new Car("Toyota", "Camry", 2020);

//        Console.WriteLine($"{myCar.Year} {myCar.Make} {myCar.Model} - Mileage: {myCar.Mileage} miles, Fuel: {myCar.Fuel} gallons");

//        myCar.Drive(50);

//        myCar.AddFuel(5);

//        myCar.Drive(100);

//        myCar.AddFuel(2);
//        myCar.Drive(30);
//    }
//}

// #################################################################