// ###############################################
// ## Task 1

//Console.WriteLine("Create a list of integers and display the sum of all the elements in the list.");
//Console.WriteLine("___Task 1___\n");

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//int sum = 0;
//foreach (int number in numbers) 
//{
//    sum += number;
//}
//Console.WriteLine("The sum of all the elements in the list is: " + sum);

// ###############################################
// ## Task 2

//Console.WriteLine("Create a list of strings and concatenate all the strings into a single string.");
//Console.WriteLine("___Task 2___\n");

//List<string> words = new List<string> { "hello", "world", "!" };
//string concat = "";
//foreach (string word in words) 
//{
//    concat += word;
//}
//Console.WriteLine("The concatenated string is: " + concat);

// ###############################################
// ## Task 3

//Console.WriteLine("Create a list of dates and sort them in ascending order.");
//Console.WriteLine("___Task 3___\n");

//List<DateTime> dates = new List<DateTime>
//{
//new DateTime(2020, 10, 1),
//new DateTime(2022, 8, 15),
//new DateTime(2021, 4, 28)
//};
//Console.WriteLine("The sorted dates are:");
//dates.Sort();
//foreach (DateTime date in dates)
//{
//    Console.WriteLine(date.ToShortDateString());
//}

// ###############################################
// ## Task 4

//Console.WriteLine("Create a list of doubles and find the average value of all the elements in the list.");
//Console.WriteLine("___Task 4___\n");

//List<double> numbers = new List<double> { 3.5, 2.7, 6.9, 1.2 };
//double average = numbers.Average();
//Console.WriteLine("The average value of all the elements in the list is: " + average);

// ###############################################
// ## Task 5

//Console.WriteLine("Create a list of integers and print all elements that are even. (use `FindAll` method).");
//Console.WriteLine("___Task 5___\n");

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//Console.WriteLine("The filtered numbers are:");
//List<int> evenNumbers = numbers.FindAll(number => number % 2 == 0);
//foreach (int number in evenNumbers)
//{
//    Console.Write(number  + " ");
//}

// ###############################################
// ## Task 6

//Console.WriteLine("Create a list of booleans and check if all the elements in the list are true. (use `All` method).");
//Console.WriteLine("___Task 6___\n");

//List<bool> values = new List<bool> { true, true, true };
//bool allTrue = values.TrueForAll(x => x);
//Console.WriteLine("Are all the values in the list true? " + allTrue);

// ###############################################
// ## Task 7

//Console.WriteLine("Removing an element from a list.");
//Console.WriteLine("___Task 7___\n");

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//Console.WriteLine("List ichidagi elementlar: ");
//foreach (int number in numbers)
//{
//    Console.Write(number + " ");
//}
//Console.WriteLine("");
//numbers.Remove(5);
//Console.WriteLine("List ichidagi element o`chirildi: ");
//foreach (int number in numbers) 
//{
//    Console.Write(number + " ");
//}

// ###############################################
// ## Task 8

//Console.WriteLine("Searching for an element in a list.");
//Console.WriteLine("___Task 8___\n");

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//if (numbers.Contains(3)) { Console.WriteLine("List ichida bor"); }
//else { Console.WriteLine("List ichida yo`q"); }

// ###############################################
// ## Task 9

//Console.WriteLine("Adding items to a list and displaying them.");
//Console.WriteLine("___Task 9___\n");

//List<int> numbers = new List<int>(5);
//{
//    numbers.Add(1);
//    numbers.Add(2);
//    numbers.Add(3);
//    numbers.Add(4);
//    numbers.Add(5);
//}

//foreach (int i in numbers) 
//{
//    Console.Write(i + " ");
//}

// ###############################################
// ## Task 10

//Console.WriteLine("Create a list and fill it with random numbers. Print all the numbers.");
//Console.WriteLine("___Task 10___\n");

//List<int> numbers = new List<int>();

//Random rnd = new Random();

//for (int i = 0; i < 10; i++) 
//{
//    int randomNumber = rnd.Next(1, 100);
//    numbers.Add(randomNumber);
//}
//Console.WriteLine("Random sonlar: ");
//foreach (int number in numbers) 
//{
//    Console.Write(number + " ");
//}

// ###############################################