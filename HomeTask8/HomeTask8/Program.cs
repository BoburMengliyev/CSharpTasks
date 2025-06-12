// #########################################################################
// ### Task 1 

//Book book = new Book(title: "name", author: "name2", year: 2001);

//Console.WriteLine("\t---Task 1---\n");
//Console.Write("Kitob nomini kiriting: ");
//book.title = Console.ReadLine();

//Console.Write("Kitob mualifini kiriting: ");
//book.author = Console.ReadLine();

//Console.Write("Kitob nashir yilini kiriting: ");
//book.year = int.Parse(Console.ReadLine());

//book.GetInfo();
//bool result = book.IsPublishedRecently();
//Console.WriteLine("Yaqinda nashr etilganmi? " + result);

//public class Book 
//{
//    public string title { get; set; }
//    public string author { get; set; }
//    public int year { get; set; }

//    public void GetInfo() 
//    {
//        Console.WriteLine($"\nKitob nomi {title}. Bu kitobni {author} yozgan. Bu kitob {year} chiqqan...");
//    }

//    public bool IsPublishedRecently() 
//    {
//        if (year < 2010)
//        {
//            return false;
//        }
//        else
//        {
//            return true;
//        }
//    }

//    public Book(string title, string author, int year) 
//    {
//        this.title = title;
//        this.author = author;
//        this.year = year;
//    }
//}

// #########################################################################
// ### Task 2

//Console.WriteLine("\t---Task 2---\n");
//Console.Write("Foydalanuvchi doira radiusini kiriting >> ");
//double inputRadius = Convert.ToDouble(Console.ReadLine());

//Circle circle = new Circle();
//circle.SetRadius(inputRadius);

//Console.WriteLine("\nDoiraning yuzasi >> " + circle.GetArea());
//Console.WriteLine("Doiraning diametri >> " + circle.GetDiameter());
//Console.WriteLine("Doiraning uzunligi >> " + circle.GetCircumference());

//public class Circle 
//{
//    public double radius {  get; set; }
//    public const double PI = 3.14159;

//    public Circle() { }

//    public Circle (double radius) 
//    {
//        this.radius = radius;
//    }

//    public void SetRadius(double radius) 
//    {
//        this.radius = radius;
//    }

//    public double GetRadius() => radius;
//    public double GetArea() => PI * radius * radius;
//    public double GetDiameter() => radius * 2;
//    public double GetCircumference() => 2 * PI * radius;
//}

// #########################################################################
// ### Task 3

//Date date = new Date();
//Console.WriteLine("\t---Task 3---\n");

//Console.Write("Kunni kiriting >> ");
//int day = int.Parse(Console.ReadLine());

//Console.Write("Oyni kiirting >> ");
//int month = int.Parse(Console.ReadLine());

//Console.Write("Yilni kiriting >> ");
//int year = int.Parse(Console.ReadLine());
//date.SetDate(day, month, year);

//Console.WriteLine("Natija >> " + date);

//public class Date
//{
//    private int day;
//    private int month;
//    private int year;

//    public Date() { }
//    public Date(int day) => this.day = day;
//    public Date(int day, int month) 
//    {
//        this.day = day;
//        this.month = month;
//    }

//    public Date(int day, int month, int year) 
//    {
//        this.day = day;
//        this.month = month;
//        this.year = year;
//    }

//    public void SetDate(int day, int month, int year) 
//    {
//        this.day = day;
//        this.month = month;
//        this.year = year;
//    }

//    public int GetDay() => day;
//    public int GetMonth() => month;
//    public int GetYear() => year;

//    public override string ToString() 
//    {
//        return $"{day:D2}/{month:D2}/{year}";
//    }
//}

// #########################################################################
// ### Task 4
Console.WriteLine("\t---Task 4---\n");
BankAccount account = new BankAccount(1001, "John Doe", 5000.00m);

account.Deposit(1000.00m);
account.Withdraw(200.00m);

account.FreezeAccount();
account.Deposit(500.00m);

account.UnfreezeAccount();
account.Deposit(500.00m);

Console.ReadKey();

public class BankAccount 
{
    private int accountId;
    private decimal balance;
    private bool isFrozen;
    public string OwnerName { get; set; }

    public BankAccount(int accountId, string ownerName, decimal balance) 
    {
        this.accountId = accountId;
        this.OwnerName = ownerName;
        this.balance = balance;
        this.isFrozen = false;
    }

    public void Deposit(decimal amount) 
    {
        if (isFrozen)
        {
            Console.WriteLine("Hisob muzlatilgan. Pul qo‘shib bo‘lmaydi.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Kirim miqdori musbat bo‘lishi kerak.");
            return;
        }

        balance += amount;
        Console.WriteLine($"{amount} so‘m qo‘shildi. Yangi balans: {balance} so‘m");
    }

    public void Withdraw(decimal amount) 
    {
        if (isFrozen)
        {
            Console.WriteLine("Hisob muzlatilgan. Pul yechib bo‘lmaydi.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Chiqim miqdori musbat bo‘lishi kerak.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Yetarli mablag‘ mavjud emas.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"{amount} so‘m yechildi. Yangi balans: {balance} so‘m");
    }

    public void FreezeAccount() 
    {
        isFrozen = true;
        Console.WriteLine("Hisob muvaffaqiyatli muzlatildi.");
    }

    public void UnfreezeAccount() 
    {
        isFrozen = false;
        Console.WriteLine("Hisob muvaffaqiyatli ochildi.");
    }

    public void ShowStatus()
    {
        Console.WriteLine($"ID: {accountId}, Ega: {OwnerName}, Balans: {balance} so‘m, Muzlatilgan: {isFrozen}");
    }
}