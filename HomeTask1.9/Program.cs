// ##################################
// ### Task 1:

//DateTime dateTime = DateTime.Now;
//Console.WriteLine("Year = " + dateTime.Year);
//Console.WriteLine("Month = " + dateTime.Month);
//Console.WriteLine("Day = " + dateTime.Day);
//Console.WriteLine("Hour = " + dateTime.Hour);
//Console.WriteLine("Minute = " + dateTime.Minute);
//Console.WriteLine("Second = " + dateTime.Second);
//Console.WriteLine("Millisecond = " + dateTime.Millisecond);

// ##################################
// ### Task 2:

//int count = 0;
//while (true) 
//{
//    string input = Console.ReadLine();
//    if (input == "end") 
//    {
//        break;
//    }
//    count++;
//}
//Console.WriteLine(count);

// ##################################
// ### Task 3:

//using HomeTask19;

//Gauge gauge = new Gauge();
//int input = int.Parse(Console.ReadLine());
//gauge.Value = input;

//gauge.Increase();
//gauge.Decrease();
//Console.WriteLine(gauge.Full());

// ##################################
// ### Task 4:

//using HomeTask19;

//Counter counter = new Counter();

//Console.Write("Boshlang'ich qiymat kiriting: ");
//int input = int.Parse(Console.ReadLine());
//counter.Value = input;

//counter.Increase();
//Console.WriteLine("1 ga oshirilgan: " + counter.Value);

//counter.Decrease();
//Console.WriteLine("1 ga kamaytirilgan: " + counter.Value);

//Console.Write("Nechchaga oshirmoqchisiz? ");
//int inc = int.Parse(Console.ReadLine());
//counter.Increase(inc);
//Console.WriteLine($"{inc} ga oshirilgan: " + counter.Value);

//Console.Write("Nechchaga kamaytirmoqchisiz? ");
//int dec = int.Parse(Console.ReadLine());
//counter.Decrease(dec);
//Console.WriteLine($"{dec} ga kamaytirilgan: " + counter.Value);

// ##################################
// ### Task 5:

using HomeTask19.Task5;

PaymentTerminal terminal = new PaymentTerminal();
PaymentCard card = new PaymentCard(5.0);

Console.WriteLine(card);

bool lunchPaid = terminal.BuyLunchWithCard(card);
Console.WriteLine($"Lunch paid with card: {lunchPaid}");
Console.WriteLine(card);

terminal.AddMoneyToCard(card, 20);
Console.WriteLine(card);

terminal.BuyCoffeeWithCard(card);
terminal.BuyLunchWithCash(15);
terminal.BuyCoffeeWithCash(3);

Console.WriteLine(terminal);