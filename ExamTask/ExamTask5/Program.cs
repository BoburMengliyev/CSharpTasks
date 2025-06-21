using ExamTask5;

var student = new Student("Bobur", "Boysun", 2001, 105000, "IT");
Console.WriteLine(student.ToString());
Console.WriteLine();

student.SetProgram("Designer");
Console.WriteLine($"New Program: {student.GetProgram()}");
student.SetYear(2011);
Console.WriteLine($"New Year: {student.GetYear()}");
student.SetFee(855654);
Console.WriteLine($"New Fee: {student.GetFee()}");
Console.WriteLine();
Console.WriteLine(student.ToString());


var staff = new Staff("Jasur", "Surxondaryo", "6-makatab", 2000000);
Console.WriteLine(staff.ToString());
Console.WriteLine("");
staff.SetSchool("49-maktab");
Console.WriteLine($"New school: {staff.GetSchool()}");
staff.SetPay(785215);
Console.WriteLine($"New pay: {staff.GetPay()}");
Console.WriteLine("");
Console.WriteLine(staff.ToString());