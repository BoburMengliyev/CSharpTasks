// ####################################
// ### Task 1:

//using HomeTask18;

//Console.Write("Depozit qushing: ");
//double dep = Convert.ToDouble(Console.ReadLine());
//Account account = new Account(dep);
//account.AddBalance();
//Console.WriteLine("Balans: " + account.getBalance());

// ####################################
// ### Task 2:

//using HomeTask18;

//Account heikkiAccount = new Account(1000.0);

//Account personalAccount = new Account(0.0);

//heikkiAccount.Withdraw(100);
//personalAccount.Deposit(100);

//Console.WriteLine("Heikki's account balance: " + heikkiAccount);
//Console.WriteLine("Personal account balance: " + personalAccount);

// ####################################
// ### Task 3:

//using HomeTask18;

//Dog dog = new Dog("Toby", "Apcharka", 2);
//Console.WriteLine("Name; " + dog.GetName());
//Console.WriteLine("Breed: "+ dog.GetBreed());
//Console.WriteLine("Age: " + dog.GetAge());

//####################################
//### Task 4:

//using HomeTask18;

//Product product = new Product("Olma", 10.5, 5);
//product.PrintProduct();

// ####################################
// ### Task 5:

using HomeTask18;

Counter counter = new Counter(5);
Console.WriteLine(counter.PrintValue());
counter.Decrement();
Console.WriteLine(counter.PrintValue());
counter.Reset();
Console.WriteLine(counter.PrintValue());