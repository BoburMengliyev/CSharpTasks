// ###########################################################################
// ### Task1

//Rectangle rectangle = new Rectangle();
//rectangle.Width = 5;
//rectangle.Height = 3;
//rectangle.Color = "Red";

//Console.WriteLine("Area: " + rectangle.GetArea());
//Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
//Console.WriteLine("Color: " + rectangle.Color);

//public class Rectangle 
//{
//    public int Width;
//    public int Height;
//    public string Color;

//    public int GetArea() {
//        return (int) (Width * Height);
//    }

//    public int GetPerimeter() 
//    {
//        return 2 * (Width  +  Height);
//    }
//}

// ###########################################################################
// ### Task2

//User user = new User();
//Console.Write("Ismingizni kiriting: ");
//user.FirstName = Console.ReadLine();
//Console.Write("Familyangizni kiriting: ");
//user.LastName = Console.ReadLine();
//Console.Write("User name kiriting: ");
//user.Username = Console.ReadLine();
//Console.Write("Parolingizni kiriting: ");
//user.Password = Console.ReadLine();

//Console.WriteLine("\n Endi tizimga kirishni sinab ko'ring.");
//Console.Write("Username: ");
//string enteredUsername = Console.ReadLine();

//Console.Write("Password: ");
//string enteredPassword = Console.ReadLine();

//user.Login(enteredUsername, enteredPassword);
//Console.WriteLine("\nFoydalanuvchi holati:");
//Console.WriteLine(user.GetFullInfo());

//Console.WriteLine("\nLogout bo'lishni xohlaysizmi? (yes/no)");
//string logoutAnswer = Console.ReadLine();

//if (logoutAnswer.ToLower() == "yes")
//{
//    user.Logout();
//    Console.WriteLine("User logged out.");
//    Console.WriteLine(user.GetFullInfo());
//}

//public class User 
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Username { get; set; }
//    public string Password { get; set; }
//    public bool IsLoggedIn { get; set; }

//    public void Login(string username, string password) 
//    {
//        if (username == Username && password == Password)
//        {
//            IsLoggedIn = true;
//            Console.WriteLine("User logged in successfully");
//        } else 
//        {
//            Console.WriteLine("Your password or username is incorrect");
//        }
//    }

//    public void Logout() 
//    {
//        IsLoggedIn = false;
//    }

//    public string GetFullInfo() 
//    {
//        return $" {FirstName} {LastName} - {IsLoggedIn}";
//    }
//} 

// ###########################################################################
// ### Task3

//Author author = new Author();

//Console.WriteLine("Ismingizni kiriting: ");
//author.name = Console.ReadLine(); 

//Console.WriteLine("Yoshingizni kiriting: ");
//author.age = int.Parse(Console.ReadLine());

//author.CelebrateBirthday();

//Console.WriteLine("Millatingizni kiriting: ");
//author.nationality = Console.ReadLine();

//author.Introduce();

//public class Author
//{
//    public string name { get; set; }
//    public int age { get; set; }
//    public string nationality { get; set; }

//    public string GetName()
//    {
//        return name;
//    }

//    public int GetAge()
//    {
//        return age;
//    }

//    public string GetNationality()
//    {
//        return nationality;
//    }

//    public void Introduce()
//    {
//        Console.WriteLine($"My name is {name}. I am {age} years old. I am from {nationality}.");
//    }

//    public void CelebrateBirthday()
//    {
//        age++;
//    }

//    public Author() 
//    { }

//    public Author(string nameFul, int ageFul) 
//    {
//        name = nameFul;
//        age = ageFul;
//    }

//    public Author(string nameFul, int ageFul, string nationalityFul) 
//    {
//        name = nameFul;
//        age = ageFul;
//        nationality = nationalityFul;
//    }
//}

// ###########################################################################
// ### Task4
Console.Write("Davlat nomini kiriting => ");
string name = Console.ReadLine();
Console.Write("Davlat poytaxtini kiriting => ");
string capital = Console.ReadLine();
Console.Write("Davlat aholisini kiriting => ");
int population = int.Parse(Console.ReadLine());
Console.Write("Davlat rasmiy tilini kiriting => ");
string officialLanguage = Console.ReadLine();

Country country = new Country(name, capital, population, officialLanguage);
Console.WriteLine("\n--- Davlat haqida ma'lumot ---");
Console.WriteLine("Davlat nomi: " + country.name);
Console.WriteLine("Poytaxti: " + country.capital);
Console.WriteLine("Aholisi: " + country.population);
Console.WriteLine("Rasmiy tili: " + country.officialLanguage);

public class Country 
{
    public string name { get; set; }
    public string capital { get; set; } 
    public int population { get; set; }
    public string officialLanguage { get; set; }

    public string SetCapital(string capital) =>  this.capital = capital;
    public int SetPopulation(int population) => this.population = population;
    public string SetOfficialLanguage(string language) => this.officialLanguage = language;

    public string GetCapital() => this.capital;
    public int GetPopulation() => this.population;
    public string GetOfficialLanguage() => this.officialLanguage;

    public Country(string name, string capital, int population, string officialLanguage)
    {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.officialLanguage = officialLanguage;
    }
}