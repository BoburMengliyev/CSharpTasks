// ##################################################
// ## Task 1

//Console.WriteLine("Getting the index of the last occurrence of an element in a list.");
//Console.WriteLine("___Task 1___\n");
//List<int> numbers = new List<int>(5) { 5, 3, 7, 3, 9 };
//int element = 3;
//int lastIndex = numbers.LastIndexOf(element);
//Console.WriteLine(lastIndex);

// ##################################################
// ## Task 2

//Console.WriteLine("Checking if a list contains all the elements of another list.");
//Console.WriteLine("___Task 2___\n");
//List <int> numbers = new List<int>(5) { 1, 2, 3, 4, 5};
//List<int> numbers2 = new List<int>(3) { 2, 4, 5 };
//bool foundElement = !numbers2.Except(numbers).Any();
//Console.WriteLine("Hammasi bor: " + foundElement);

// ##################################################
// ## Task 3

//Console.WriteLine("Write program to Reverse the order of elements in a list.");
//Console.WriteLine("___Task 3___\n");
//List <int> numbers = new List<int>(5) { 1, 2, 3, 4, 5};
//numbers.Reverse();
//foreach (int number in numbers) 
//{
//    Console.Write(number + " ");
//}

// ##################################################
// ## Task 4

//Console.WriteLine("Write program to Checking if the list is empty.");
//Console.WriteLine("___Task 4___\n");

//List <int> number = new List<int>(5) { 1, 2, 3, 4, 5};
//if (number.Count == 0)
//{
//    Console.WriteLine("List bo`sh");
//}
//else 
//{
//    Console.WriteLine("Listda element bor");
//}

// ##################################################
// ## Task 5

//Console.WriteLine("Write program to Getting a sublist from the main list.");
//Console.WriteLine("___Task 5___\n");

//List <int> number = new List<int>(5) { 1, 2, 3, 4, 5};
//List <int> subList = number.GetRange(0, 2);

//foreach (int i in subList) 
//{
//    Console.WriteLine(i);
//}

// ##################################################
// ## Task 6

//Console.WriteLine("Write programs to sort list items.");
//Console.WriteLine("___Task 6___\n");

//List<int> number = new List<int>(10) { 5, 4, 7, 1, 3, 6, 8, 2, 9, 0 };
//number.Sort();
//foreach (int i in number) 
//{
//    Console.Write(i + " ");
//}

// ##################################################
// ## Task 7

//Console.WriteLine("Write programs to clear all given lists of elements.");
//Console.WriteLine("___Task 7___\n");

//List<int> number = new List<int>(10) { 5, 4, 7, 1, 3, 6, 8, 2, 9, 0 };
//number. Clear();
//Console.WriteLine("Tozalandi: ");
//Console.Write("1 ni qushamiz: ");
//number. Add(1);
//foreach (var item in number) 
//{
//    Console.WriteLine(item);
//}

// ##################################################
// ## Task 8

//Console.WriteLine("Finding the largest and smallest elements in a list.");
//Console.WriteLine("___Task 8___\n");

//List<int> number = new List<int>(10) { 5, 4, 7, 1, 3, 6, 8, 2, 9, 0 };
//Console.Write("Minimum: " + number.Min());
//Console.WriteLine();
//Console.WriteLine("Maximum: " + number.Max());

// ##################################################
// ## Task 9

//Console.WriteLine("Removing all elements that match a certain condition.");
//Console.WriteLine("___Task 9___\n");

//List<int> number = new List<int>(10) { 5, 4, 7, 1, 3, 6, 8, 2, 9, 0 };
//Console.WriteLine("List ichidagi elementlar: ");
//foreach (int i in number) 
//{
//    Console.Write(i + " ");
//}
//number.RemoveRange(0, 5);
//Console.WriteLine("\n");
//Console.WriteLine("Belgilangan indexlar oralig`ini o`chirish: ");
//foreach (int i in number) 
//{
//    Console.Write(i + " ");
//}

// ##################################################
// ## Task 10

//Console.WriteLine("Mixing list items randomly.");
//Console.WriteLine("___Task 10___\n");

//List<int> number = new List<int>(10) { 5, 4, 7, 1, 3, 6, 8, 2, 9, 0 };
//Random rnd = new Random();

//for (int i = number.Count - 1; i > 0; i--) 
//{
//    int  j = rnd.Next(0, i + 1);
//    int vaqtiincha = number[j];
//    number[i] = number[j];
//    number[j] = vaqtiincha;
//}

//Console.Write("Tasodifiy tartib raqamlar: " + string.Join(", ", number));

// ##################################################