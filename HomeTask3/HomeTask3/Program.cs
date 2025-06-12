// ###############################################################
// ### Task1

//static void PrintNaturalNumbers(int numbers, int count = 1) 
//{
//    if (count > numbers)
//    {
//        return;
//    }
//    Console.Write(count  + " ");
//    PrintNaturalNumbers(numbers, count + 1);
//}

//Console.WriteLine("Son kiriting: ");
//int numbers = int.Parse(Console.ReadLine());

//PrintNaturalNumbers(numbers);

// ###############################################################
// ### Task2

//static void PrintNaturalNumbers (int count) 
//{
//    if (count < 1) 
//    {
//        return;
//    }
//    Console.Write(count + " ");
//    PrintNaturalNumbers(count - 1);
//}

//Console.WriteLine("Son kiriting: ");
//int numbers = int.Parse(Console.ReadLine());

//PrintNaturalNumbers(numbers);

// ###############################################################
// ### Task3

//static int Sum(int numbers) 
//{
//    if (numbers == 0) return 0;
//    return numbers + Sum(numbers - 1);
//}

//Console.WriteLine("Son kiriting: ");
//int numbers = int.Parse(Console.ReadLine());

//int natija = Sum(numbers);
//Console.WriteLine(natija);

// ###############################################################
// ### Task4

//Console.WriteLine("Son kiriting: ");
//int numbers = int.Parse(Console.ReadLine());
//PrintDigits(numbers);

//static void PrintDigits(int numbers) 
//{
//    if (numbers == 0) return;
//    PrintDigits(numbers / 10);

//    Console.Write((numbers % 10) + " ");
//}

// ###############################################################
// ### Task5

//Console.WriteLine("Son kiriting: ");
//int numbers = int.Parse(Console.ReadLine());
//int natija = CountDigits(numbers);
//Console.WriteLine(natija);

//static int CountDigits(int numbers)
//{
//    if (numbers < 0) 
//        numbers = -numbers;

//    if (numbers == 0)
//        return 1;

//    if (numbers < 10)
//        return 1;

//    return 1 + CountDigits(numbers / 10);
//}

// ###############################################################
// ### Task6

//Console.WriteLine("Boshlanish va tugash sonini kiriting: ");
//string[] input = Console.ReadLine().Split();
//int start = int.Parse(input[0]);
//int end = int.Parse(input[1]);

//Console.WriteLine("All even numbers from {0} to {1} are :", start, end);
//PrintEven(start, end);

//Console.WriteLine();

//Console.WriteLine("All odd numbers from {0} to {1} are :", start, end);
//PrintOdd(start, end);

//static void PrintEven(int current, int end)
//{
//    if (current > end)
//        return;

//    if (current % 2 == 0)
//        Console.Write(current + " ");

//    PrintEven(current + 1, end);
//}

//static void PrintOdd(int current, int end)
//{
//    if (current > end)
//        return;

//    if (current % 2 != 0)
//        Console.Write(current + " ");

//    PrintOdd(current + 1, end);
//}

// ###############################################################
// ### Task6