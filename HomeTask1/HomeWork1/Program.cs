// This is a comment
// Console.WriteLine("Hello, World"); // cout<<"Hello, World!"<< endl;
// Console.WriteLine("C++");

// Console.Write("You are styding c# "); // cout << "hello";

// /* The code bellow will print the words Hello World to the screen, and it is amazing */
// Console.WriteLine("Welcome to hardworking zone!");

// Console.WriteLine("Hello World!");
// Console.WriteLine("I am Learning C#");
// Console.WriteLine("It is awesome!");

// Console.Write("Hey hi");
// Console.Write("Friend");

// Console.WriteLine(); // empty line
// Console.WriteLine(); // empty line
// Console.WriteLine(); // empty line

// Console.WriteLine(3 + 3); // calculations

// int , double, char, string, bool

// int son = 99;
// Console.WriteLine(son);
// string name;
// name = "Bobur";
// Console.WriteLine(name);
// int myNum;
// myNum = 15;
// Console.WriteLine(myNum);

// C# INPUT

// // Type your username and press enter
// Console.WriteLine("Enter username: ");

// // Create a string variable and get user input from the
// // keyboard and store it in the variable
// string userName = Console.ReadLine();

// // Print the value of the variable (userName), which
// // will display the input value
// Console.WriteLine("Username is: " + userName);

// int myInt = 10;
// double myDouble = 5.25;
// bool myBool = true;

// Console.WriteLine(Convert.ToString(myInt)); // convert int to string
// Console.WriteLine(Convert.ToDouble(myInt)); // convert int to double
// Console.WriteLine(Convert.ToInt32(myDouble)); // convert double to int
// Console.WriteLine(Convert.ToString(myBool)); // convert bool to string

// Console.WriteLine("Enter your name: ");
// string? name = Console.ReadLine(); // string

// Console.Write("How old are you?: ");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.Write("Your height: ");
// double height = Convert.ToDouble(Console.ReadLine());

// Console.Write("Your salary: ");
// decimal salary = Convert.ToDecimal(Console.ReadLine());

// Console.WriteLine($"Name: {name} Age: {age} Height: {height}m Salary: {salary}$");

// if (Condition1)
// {
//     // block of code to be executed if condition1 is True
// }
// else if (Condition2)
// {
//     /* block of code to be executed if the condition1 is false and condition2 is True */
// }
// else
// {
//     /* block of code to be executed if the condition1 is false and condition2 is False */
// }

// int time = 22;
// if (time < 10)
// {
//     Console.WriteLine("Good morning.");
// }
// else if (time < 20)
// {
//     Console.WriteLine("Good day.");
// }
// else
// {
//     Console.WriteLine("Good evening.");
// }
// Outputs "Good evening."

// char ch = 'i';
// switch (ch)
//     {
//         case 'a':
//             Console.WriteLine("Vowel");
//             break;
//         case 'e':
//             Console.WriteLine("Vowel");
//             break;
//         case 'i':
//             Console.WriteLine("Vowel");
//             break;
//         case 'o':
//             Console.WriteLine("Vowel");
//             break;
//         case 'u':
//             Console.WriteLine("Vowel");
//             break;
//         default:
//             Console.WriteLine("Consonant");
//             break;
//     }

// Switch case in C# 11.0

// var number = 2;

// var result = number switch
// {
//     1-> "Case 1",
//     2-> "Case 2",
//     - -> "Not match"
// };

// syntax
// for (initialization; condition; iterator)
// {
//     // body of for loop
// }

// for (int i = 1; i <= 3; i++)
// {
//     Console.WriteLine($"C# For Loop: Iteration {i}");
// }

// int n = 10, sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     // sum = sum + i;
//     sum += i;
// }

// Console.WriteLine($"Sum of first (n) natural numbers = {sum}");

// Outputs : Sum of first 10 natural numbers = 55 

// while (test - expression)
// {
//     // body of while
// }

// int counter = 1;
// while (counter <= 5)
// {
//     Console.WriteLine($"C# While Loop: Iteration {counter}");
//     counter++;
// }

// C# While Loop: Iteration 1
// C# While Loop: Iteration 2
// C# While Loop: Iteration 3
// C# While Loop: Iteration 4
// C# While Loop: Iteration 5

// int i = 1, n = 5;
// do
// {
//     Console.WriteLine($"{n} * {i} = {n * i}");
//     i++;
// } while (i <= 5);
// 5 * 1 = 5
// 5 * 1 = 10
// 5 * 1 = 15
// 5 * 1 = 20
// 5 * 1 = 25

// example
// for (int i = 1; i <= 4; ++i)
// {
//     // terminates the loop
//     if (i == 3)
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }

// 1
// 2

// for (int i = 1; i <= 5; i++)
// {
//     if (i == 3)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

// 1
// 2
// 4
// 5

// C# ARRAYS

// datatype[] arrayName = valu;

// declare an array
// int[] age;

// // allocate memory for array
// age = new int[5];

// // or
// var age1 = new int[5] { 1, 2, 3, 4, 6 };

// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// int[] numbers = { 1, 2, 3, 6, 7 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine($"Element in index {i} : {numbers[i]}");
// }

// Outputs
// Element in index 0 : 1
// Element in index 1 : 2
// Element in index 2 : 3
// Element in index 3 : 6
// Element in index 4 : 7

int[] numbers = { 1, 2, 3 };
Console.WriteLine("Array Elements: ");

foreach (int num in numbers)
{
    Console.WriteLine(Math.Pow(num, 2));
}
string[] names = { "Muhammad", "Nurullo", "test" };

foreach (var name in names)
{
    System.Console.WriteLine(name);
}

// Outputs
// 1
// 4
// 9
// Muhammad
// Nurullo
// test