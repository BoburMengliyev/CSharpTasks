using LINQ.Models;

internal class Program
{
    static List<Student> students = new List<Student>
    {
        new Student { StudentId = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
        new Student { StudentId = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
        new Student { StudentId = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) }
    };

    static List<Course> courses = new List<Course>
    {
        new Course { CourseId = 101, Title = "Mathematics", Credits = 4 },
        new Course { CourseId = 102, Title = "Computer Science", Credits = 3 },
        new Course { CourseId = 103, Title = "Physics", Credits = 4 }
    };

    static List<Enrollment> enrollments = new List<Enrollment>
    {
        new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
        new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
        new Enrollment { EnrollmentId = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
        new Enrollment { EnrollmentId = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
        new Enrollment { EnrollmentId = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
        new Enrollment { EnrollmentId = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) }
    };

    static List<City> cities = new List<City>()
     {
        new City { CityId = 1, Name = "Tashkent" },
        new City { CityId = 2, Name = "Samarkand" },
        new City { CityId = 3, Name = "Bukhara" },
        new City { CityId = 4, Name = "Andijan" },
        new City { CityId = 5, Name = "Namangan" },
        new City { CityId = 6, Name = "Fergana" }
    };

    static List<Person> people = new List<Person>()
    {
        new Person { Id = 1, Name = "Ali", Age = 25, CityId = 1 },
        new Person { Id = 2, Name = "Vali", Age = 30, CityId = 2 },
        new Person { Id = 3, Name = "Hasan", Age = 22, CityId = 3 },
        new Person { Id = 4, Name = "Husan", Age = 28, CityId = 1 },
        new Person { Id = 5, Name = "Jasur", Age = 35, CityId = 4 },
        new Person { Id = 6, Name = "Dilshod", Age = 27, CityId = 5 },
        new Person { Id = 7, Name = "Madina", Age = 23, CityId = 6 }
    };
    private static void Main(string[] args)
    {
        // Task 1: "Matematika" kursiga yozilgan barcha talabalarni toping.
        var query1 = from e in enrollments
                     join s in students on e.StudentId equals s.StudentId
                     join c in courses on e.CourseId equals c.CourseId
                     where c.Title == "Mathematics"
                     select new { s.Name, s.DateOfBirth };
        Console.WriteLine("Matematikaga yozilgan talabalar:");
        foreach (var student in query1)
        {
            Console.WriteLine($"Name: {student.Name}, Date of Birth: {student.DateOfBirth}");
        }
        Console.WriteLine();

        // Task 2: "Charlie" qaysi kurslarga yozilganini topish.
        var query2 = from e in enrollments
                     join s in students on e.StudentId equals s.StudentId
                     join c in courses on e.CourseId equals c.CourseId
                     where s.Name == "Charlie"
                     select new { c.Title, c.Credits };
        Console.WriteLine("Charli ro'yxatdan o'tgan kurslar:");
        foreach (var course in query2)
        {
            Console.WriteLine($"Course: {course.Title}, Credits: {course.Credits}");
        }
        Console.WriteLine();

        // Task 3: Bir nechta kursga yozilgan talabalarni topish (SelectMany)
        var query3 = students
            .Select(s => new
            {
                s.Name,
                Courses = enrollments.Where(e => e.StudentId == s.StudentId).Select(e => e.CourseId)
            })
            .Where(s => s.Courses.Count() > 1);

        Console.WriteLine("Bir nechta kursga yozilgan talabalar:");
        foreach (var student in query3)
        {
            Console.WriteLine($"Name: {student.Name}, Course Count: {student.Courses.Count()}");
        }
        Console.WriteLine();


        // Task 4: Yosh oralig‘i va kurs bo‘yicha guruhlash, o‘rtacha yosh hisoblash
        var query4 = enrollments
            .Join(students, e => e.StudentId, s => s.StudentId, (e, s) => new
            {
                s.Name,
                Age = DateTime.Now.Year - s.DateOfBirth.Year,
                e.CourseId
            })
            .Join(courses, es => es.CourseId, c => c.CourseId, (es, c) => new
            {
                es.Age,
                AgeRange = $"{(es.Age / 10) * 10}s", // masalan, 20s
                c.Title
            })
            .GroupBy(x => new { x.AgeRange, x.Title })
            .Select(g => new
            {
                g.Key.AgeRange,
                CourseTitle = g.Key.Title,
                AverageAge = g.Average(x => x.Age)
            });

        Console.WriteLine("Yosh oralig‘i va kurs bo‘yicha guruhlash:");
        foreach (var group in query4)
        {
            Console.WriteLine($"Age Range: {group.AgeRange}, Course: {group.CourseTitle}, Average Age: {group.AverageAge:F1}");
        }
        Console.WriteLine();


        // Task 5: Talaba, ro'yxatdan o'tish va kursga qo'shiling va ro'yxatdan o'tish sanasi va kurs kreditlari bo'yicha filtrlang.
        var query5 = from e in enrollments
                     join s in students on e.StudentId equals s.StudentId
                     join c in courses on e.CourseId equals c.CourseId
                     where e.EnrollmentDate > new DateTime(2023, 1, 20) && c.Credits >= 4
                     select new { s.Name, c.Title, e.EnrollmentDate };
        Console.WriteLine("Yozilgan talabalar (2023-01-20 dan keyin) va 4 kreditli kurslar:");
        foreach (var enrollment in query5)
        {
            Console.WriteLine($"Name: {enrollment.Name}, Course: {enrollment.Title}, Enrollment Date: {enrollment.EnrollmentDate}");
        }
        Console.WriteLine();

        // Task 6: Har bir talaba ro'yxatdan o'tgan umumiy kreditlarni hisoblang.
        var query6 = from e in enrollments
                     join s in students on e.StudentId equals s.StudentId
                     join c in courses on e.CourseId equals c.CourseId
                     group c by s into studentGroup
                     select new
                     {
                         StudentName = studentGroup.Key.Name,
                         TotalCredits = studentGroup.Sum(c => c.Credits)
                     };
        Console.WriteLine("Har bir talabaga yozilgan umumiy kreditlar:");
        foreach (var student in query6)
        {
            Console.WriteLine($"Name: {student.StudentName}, Total Credits: {student.TotalCredits}");
        }
        Console.WriteLine();

        // Task 7: Har bir kursga nechta talaba yozilganini topish.
        var query7 = enrollments
            .GroupBy(e => e.CourseId)
            .Select(g => new
            {
                CourseTitle = courses.First(c => c.CourseId == g.Key).Title,
                StudentCount = g.Select(e => e.StudentId).Distinct().Count()
            });
        Console.WriteLine("Har bir kursga yozilgan talabalar soni:");
        foreach (var course in query7)
        {
            Console.WriteLine($"Course: {course.CourseTitle}, Student Count: {course.StudentCount}");
        }
        Console.WriteLine();


        // Task 8: Muayyan talaba, "Bob" deb aytmagan barcha kurslarni toping.
        var query8 = from c in courses
                     where !enrollments.Any(e => e.CourseId == c.CourseId && e.StudentId == students.First(s => s.Name == "Bob").StudentId)
                     select c;
        Console.WriteLine("Bob yozilmagan kurslar:");
        foreach (var course in query8)
        {
            Console.WriteLine($"Course: {course.Title}, Credits: {course.Credits}");
        }
        Console.WriteLine();

        // Task 9: Ismining uzunligi 4 dan katta bo'lgan barcha odamlarni toping. Shaxs nomini va shaxs ismining uzunligini chop eting.
        var query9 = from p in people
                     where p.Name.Length > 4
                     select new { p.Name, Length = p.Name.Length };
        Console.WriteLine("Ismi uzunligi 4 dan katta bo'lgan odamlar:");
        foreach (var person in query9)
        {
            Console.WriteLine($"Name: {person.Name}, Length: {person.Length}");
        }
        Console.WriteLine();

        // Task 10: Odamlarni shahar bo'yicha guruhlang, har bir guruhga yoshi bo'yicha buyurtma bering va har bir shaharda eng yosh odamni tanlang.
        var query10 = from p in people
                      group p by p.CityId into cityGroup
                      let youngestPerson = cityGroup.OrderBy(p => p.Age).FirstOrDefault()
                      select new
                      {
                          CityName = cities.First(c => c.CityId == cityGroup.Key).Name,
                          YoungestPerson = youngestPerson.Name,
                          Age = youngestPerson.Age
                      };
        Console.WriteLine("Har bir shahar bo'yicha eng yosh odamlar:");
        foreach (var city in query10)
        {
            Console.WriteLine($"City: {city.CityName}, Youngest Person: {city.YoungestPerson}, Age: {city.Age}");
        }
        Console.WriteLine();

        // Task 11: Har bir shahar o'z aholisi ro'yxatini o'z ichiga olgan ierarxik tuzilmani yarating va keyin har bir shahar aholisining o'rtacha yoshini hisoblang.
        var query11 = from c in cities
                      join p in people on c.CityId equals p.CityId into residents
                      select new
                      {
                          CityName = c.Name,
                          Residents = residents,
                          AverageAge = residents.Average(r => r.Age)
                      };
        Console.WriteLine("Har bir shahar va uning aholisi, o'rtacha yosh:");
        foreach (var city in query11)
        {
            Console.WriteLine($"City: {city.CityName}, Average Age: {city.AverageAge:F1}");
            foreach (var resident in city.Residents)
            {
                Console.WriteLine($"  Resident: {resident.Name}, Age: {resident.Age}");
            }
        }
        Console.WriteLine();

        // Task 12: Odamlar va shaharlar o'rtasida birlashishni amalga oshiring, so'ngra natijalarni shahar bo'yicha guruhlang va shahar nomi va rezident nomlari ro'yxatini o'z ichiga olgan yangi turni loyihalashtiring.
        var query12 = from p in people
                      join c in cities on p.CityId equals c.CityId
                      group p by c.Name into cityGroup
                      select new
                      {
                          CityName = cityGroup.Key,
                          ResidentNames = cityGroup.Select(r => r.Name).ToList()
                      };
        Console.WriteLine("Har bir shahar va uning aholisi nomlari:");
        foreach (var city in query12)
        {
            Console.WriteLine($"City: {city.CityName}");
            foreach (var residentName in city.ResidentNames)
            {
                Console.WriteLine($"  Resident: {residentName}");
            }
        }
        Console.WriteLine();

        // Task 13: Shahar nomi 'N' yoki 'L'bilan boshlanadigan shaharlarda yashovchi barcha odamlarni toping. Ushbu odamlar uchun shaxsning ismi va shahar nomini o'z ichiga olgan yangi turni loyihalashtiring.
        var query13 = from p in people
                      join c in cities on p.CityId equals c.CityId
                      where c.Name.StartsWith("N") || c.Name.StartsWith("L")
                      select new { p.Name, CityName = c.Name };
        Console.WriteLine("N yoki L bilan boshlanadigan shaharlar aholisi:");
        foreach (var person in query13)
        {
            Console.WriteLine($"Name: {person.Name}, City: {person.CityName}");
        }
    }
}