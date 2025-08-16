using ExamLinQ.Models;

List<Person> people = new List<Person>()
        {
            new Person { Id = 1, Name = "Ali", Age = 25, CityId = 1 },
            new Person { Id = 2, Name = "Vali", Age = 30, CityId = 2 },
            new Person { Id = 3, Name = "Hasan", Age = 22, CityId = 3 },
            new Person { Id = 4, Name = "Husan", Age = 28, CityId = 1 },
            new Person { Id = 5, Name = "Jasur", Age = 35, CityId = 4 },
            new Person { Id = 6, Name = "Dilshod", Age = 27, CityId = 5 },
            new Person { Id = 7, Name = "Madina", Age = 23, CityId = 6 },
            new Person { Id = 8, Name = "Alice", Age = 25, CityId = 1 },
            new Person { Id = 9, Name = "Bob", Age = 30, CityId = 1 },
            new Person { Id = 10, Name = "Charlie", Age = 22, CityId = 1 },
            new Person { Id = 11, Name = "David", Age = 28, CityId = 1 },
            new Person { Id = 12, Name = "Eva", Age = 27, CityId = 2 },
            new Person { Id = 13, Name = "Frank", Age = 33, CityId = 2 },
            new Person { Id = 14, Name = "Grace", Age = 29, CityId = 3 }
        };

List<City> cities = new List<City>()
        {
            new City { CityId = 1, Name = "Tashkent", Population = 6, CountryId = 1, CountryName = "Uzbekistan" },
            new City { CityId = 2, Name = "Samarkand", Population = 4, CountryId = 1, CountryName = "Uzbekistan" },
            new City { CityId = 3, Name = "Bukhara", Population = 5, CountryId = 1, CountryName = "Uzbekistan" },
            new City { CityId = 4, Name = "Andijan", Population = 7, CountryId = 1, CountryName = "Uzbekistan" },
            new City { CityId = 5, Name = "Namangan", Population = 3, CountryId = 1, CountryName = "Uzbekistan" },
            new City { CityId = 6, Name = "Fergana", Population = 1, CountryId = 1, CountryName = "Uzbekistan" },
            new City { CityId = 7, Name = "Paris", Population = 10, CountryId = 2, CountryName = "France" },
            new City { CityId = 8, Name = "Lyon", Population = 5, CountryId = 2, CountryName = "France" },
            new City { CityId = 9, Name = "Marseille", Population = 8, CountryId = 2, CountryName = "France" }
        };

//Task 1: Aholisi 3 dan katta bo'lgan shaharda yashovchi barcha odamlarni olish uchun LINQ usulini yozing
Console.WriteLine("Task-1");
var result1 = from person in people
              join city in cities on person.CityId equals city.CityId
              where city.Population > 3
              select new { person.Name, City = city.Name };
foreach (var item in result1)
{
    Console.WriteLine($"Ismi: {item.Name}, Shaxar: {item.City}");
}
Console.WriteLine();

//Task 2: Tegishli mamlakatda o'rtacha aholi sonidan yuqori bo'lgan barcha shaharlarni oling
Console.WriteLine("Task-2");
var result2 = cities
    .GroupBy(c => c.CountryId)
    .SelectMany(g => g.Where(c => c.Population > g.Average(x => x.Population)))
    .Select(c => new { c.Name, c.CountryName, c.Population });
foreach (var item in result2)
{
    Console.WriteLine($"Shaxar: {item.Name}, Davlat: {item.CountryName}, Aholisi: {item.Population}");
}
Console.WriteLine();

//Task 3: Har bir mamlakatda aholisi eng ko'p bo'lgan shaharlarni toping
Console.WriteLine("Task-3");
var result3 = from city in cities
              group city by city.CountryName into countryGroup
              let maxPopulation = countryGroup.Max(c => c.Population)
              from city in countryGroup
              where city.Population == maxPopulation
              select new { city.Name, city.CountryName, city.Population };
foreach (var item in result3)
{
    Console.WriteLine($"Shaxar: {item.Name}, Davlat: {item.CountryName}, Aholisi: {item.Population}");
}
Console.WriteLine();

// Task 4: Barcha odamlarni, shuningdek ularning shahar va mamlakat nomlarini oling
Console.WriteLine("Task-4");
var result4 = from person in people
              join city in cities on person.CityId equals city.CityId
              select new { person.Name, City = city.Name, Country = city.CountryName };
foreach (var item in result4)
{
    Console.WriteLine($"Ismi: {item.Name}, Shaxar: {item.City}, Davlat: {item.Country}");
}
Console.WriteLine();

// Task 5: "Elis"nomi bilan odamga ega bo'lgan barcha shaharlarni oling. Iltimos, ism katta yoki kichik harflar bo'lishi mumkinligini unutmang.
Console.WriteLine("Task-5");
var result5 = from person in people
              join city in cities on person.CityId equals city.CityId
              where person.Name.Equals("Alice", StringComparison.OrdinalIgnoreCase)
              select new { City = city.Name, Country = city.CountryName };
foreach (var item in result5)
{
    Console.WriteLine($"Shaxar: {item.City}, Davlat: {item.Country}");
}
Console.WriteLine();

// Task 6: Har bir shaharda eng keksa odamni topadigan usul yarating.
Console.WriteLine("Task-6");
var result6 = people
    .GroupBy(p => p.CityId)
    .Select(g =>
    {
        Person oldest = g.OrderByDescending(p => p.Age).First();
        City city = cities.First(c => c.CityId == g.Key);
        return new { OldestPersonName = oldest.Name, City = city.Name, Age = oldest.Age };
    });
foreach (var item in result6)
{
    Console.WriteLine($"Eng Keksa Odam: {item.OldestPersonName}, Shaxar: {item.City}, Yosh: {item.Age}");
}
Console.WriteLine();

// Task 7: Har bir mamlakatning eng gavjum shahrida yashovchi odamlarni topadigan usul yarating.
Console.WriteLine("Task-7");
var result7 = cities
    .GroupBy(c => c.CountryId)
    .SelectMany(g =>
    {
        var mostPopulousCity = g.OrderByDescending(c => c.Population).First();
        return people
            .Where(p => p.CityId == mostPopulousCity.CityId)
            .Select(p => new { p.Name, City = mostPopulousCity.Name, Country = mostPopulousCity.CountryName });
    });
foreach (var item in result7)
{
    Console.WriteLine($"Ismi: {item.Name}, Shaxar: {item.City}, Davlat: {item.Country}");
}
Console.WriteLine();

// Task 8: Shaharlarda yashovchi odamlarni ma'lum uzunlikdagi nomlar bilan topadigan usul yarating.
Console.WriteLine("Task-8");
int specificLength = 6;

var result8 = people
    .Join(cities,
          person => person.CityId,
          city => city.CityId,
          (person, city) => new { person.Name, City = city.Name })
    .Where(x => x.City.Length == specificLength);
foreach (var item in result8)
{
    Console.WriteLine($"Ismi: {item.Name}, Shaxar: {item.City}");
}
Console.WriteLine();

// Task 9: Har bir mamlakatda eng yosh odamni topadigan usulni yarating.
Console.WriteLine("Task-9");
var result9 = cities
    .GroupBy(c => c.CountryId)
    .Select(g =>
    {
        var peopleInCountry = people.Where(p => g.Any(city => city.CityId == p.CityId));
        var youngestPerson = peopleInCountry.OrderBy(p => p.Age).First();
        var city = g.First(c => c.CityId == youngestPerson.CityId);

        return new
        {
            YoungestPersonName = youngestPerson.Name,
            City = city.Name,
            Age = youngestPerson.Age,
            Country = city.CountryName
        };
    });
Console.WriteLine();

// Task 10: Belgilangan yosh oralig'ida eng ko'p odam bo'lgan shaharni topadigan usulni yarating.
Console.WriteLine("Task-10");
int minAge = 20;
int maxAge = 30;
var result10 = people
    .Where(p => p.Age >= minAge && p.Age <= maxAge)
    .GroupBy(p => p.CityId)
    .Select(g => new
    {
        CityId = g.Key,
        Count = g.Count(),
        CityName = cities.First(c => c.CityId == g.Key).Name
    })
    .OrderByDescending(x => x.Count)
    .FirstOrDefault();
if (result10 != null)
{
    Console.WriteLine($"Yosh oralig'idagi eng ko'p aholisi bo'lgan shahar {minAge} va {maxAge}: {result10.CityName}, Hisoblash: {result10.Count}");
}
else
{
    Console.WriteLine($"Yosh oralig'ida hech qanday odam topilmadi {minAge} uchun {maxAge}.");
}
Console.WriteLine();
