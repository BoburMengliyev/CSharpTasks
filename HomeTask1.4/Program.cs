// #####################################
// Task 1
// Inheritance: Superclass Person and its Subclasses

//using HomeTask14.HomeTask1.Person;
//using HomeTask14.HomeTask1.Person.Student;
//using HomeTask14.HomeTask1.Person.Teacher;

//Person person = new Person("Ali", "Toshkent");
//Console.WriteLine(person.toString());

//person.setAddress("Samarqand");
//Console.WriteLine(person.toString());

//Student student = new Student("Dilshod", "Buxoro");

//student.addCourseGrade("Math", 85);
//student.addCourseGrade("Physics", 90);
//student.printGrades();
//Console.WriteLine("Average Grade: " + student.getAverageGrade());
//Console.WriteLine(student.ToString());

//Teacher teacher = new Teacher("Shaxnoza", "Namangan");

//teacher.addCourse("C#");
//teacher.addCourse("Java");
//bool added = teacher.addCourse("C#");
//Console.WriteLine("C# qayta qo‘shish mumkinmi? " + added);
//teacher.removeCourse("Java");
//Console.WriteLine(teacher.ToString());

// #####################################
// Task 2
// Check what the counts were last week 

//using HomeTask14;

//int[] data = BirdCount.LastWeek();
//Console.WriteLine("Last week`s bird counts: ");
//foreach (int count in data) 
//{
//    Console.Write(count + " ");
//}

// #####################################
// Task 3
// Check how many birds visited today

//using HomeTask14;

//int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
//var birdCount = new BirdCount(birdsPerDay);
//birdCount.Today();

//Console.WriteLine("Today`s bird count: " + birdCount.Today());

// #####################################
// Task 4
// Increment today's count

//using HomeTask14;

//int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
//var birdCount = new BirdCount(birdsPerDay);
//birdCount.IncrementTodaysCount();
//birdCount.Today();

//Console.WriteLine("IncrementTodaysCount: " + birdCount.IncrementTodaysCount());

// #####################################
// Task 5
// Check if there was a day with no visiting birds

//using HomeTask14;

//int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
//var birdCount = new BirdCount(birdsPerDay);
//birdCount.HasDayWithoutBirds();

//Console.WriteLine(birdCount.HasDayWithoutBirds());

// #####################################
// Task 6
// Calculate the number of visiting birds for the first number of days

//using HomeTask14;

//int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
//var birdCount = new BirdCount(birdsPerDay);
//birdCount.CountForFirstDays(4);

//Console.WriteLine("CountForFirstDays: " + birdCount.CountForFirstDays(4));

// #####################################
// Task 7
// Calculate the number of busy days

//using HomeTask14;

//int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
//var birdCount = new BirdCount(birdsPerDay);
//birdCount.BusyDays();

//Console.WriteLine("BusyDays: " + birdCount.BusyDays());

// #####################################