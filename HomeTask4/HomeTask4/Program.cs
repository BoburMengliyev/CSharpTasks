// ##########################################################
// Task1

//int n = 1032845;

//Console.WriteLine("Even count: " + EvenCount(n));
//Console.WriteLine("Odd count: " + OddCount(n));
//Console.WriteLine("Zero count: " + ZeroCount(n));
//Console.WriteLine("Digit count: " + DigitCount(n));
//Console.WriteLine("Min digit: " + MinDigit(n));
//Console.WriteLine("Max digit: " + MaxDigit(n));
//Console.WriteLine("Sum of digits: " + SumDigit(n));

//static int EvenCount(int n)
//{
//    int count = 0;
//    foreach (char c in n.ToString())
//    {
//        int digit = c - '0';
//        if (digit % 2 == 0) count++;
//    }
//    return count;
//}

//static int OddCount(int n)
//{
//    int count = 0;
//    foreach (char c in n.ToString())
//    {
//        int digit = c - '0';
//        if (digit % 2 != 0) count++;
//    }
//    return count;
//}

//static int ZeroCount(int n)
//{
//    int count = 0;
//    foreach (char c in n.ToString())
//    {
//        if (c == '0') count++;
//    }
//    return count;
//}

//static int DigitCount(int n)
//{
//    return n.ToString().Length;
//}

//static int MinDigit(int n)
//{
//    int min = 9;
//    foreach (char c in n.ToString())
//    {
//        int digit = c - '0';
//        if (digit < min) min = digit;
//    }
//    return min;
//}

//static int MaxDigit(int n)
//{
//    int max = 0;
//    foreach (char c in n.ToString())
//    {
//        int digit = c - '0';
//        if (digit > max) max = digit;
//    }
//    return max;
//}

//static int SumDigit(int n)
//{
//    int sum = 0;
//    foreach (char c in n.ToString())
//    {
//        sum += c - '0';
//    }
//    return sum;
//}

// ##########################################################
// Task2

//Console.WriteLine("Enter grade:");
//int grade = int.Parse(Console.ReadLine());
//Console.WriteLine("Grade letter: " + CheckGrade(grade));


//char CheckGrade(int grade)
//{
//    if (grade >= 90 && grade <= 100)
//        return 'A';
//    else if (grade >= 80 && grade <= 89)
//        return 'B';
//    else if (grade >= 70 && grade <= 79)
//        return 'C';
//    else if (grade >= 60 && grade <= 69)
//        return 'D';
//    else if (grade >= 0 && grade <= 59)
//        return 'F';
//    else
//        throw new ArgumentOutOfRangeException("grade", "Grade must be between 0 and 100.");
//}

// ##########################################################
// Task3

//Console.Write("Enter N: ");
//int n = int.Parse(Console.ReadLine());

//int positive = 0, negative = 0, zeros = 0, even = 0, odd = 0;
//int max = int.MinValue, min = int.MaxValue;
//int sumOfDigits = 0;

//Console.WriteLine("Enter " + n + " numbers:");

//for (int i = 0; i < n; i++)
//{
//    int number = int.Parse(Console.ReadLine());

//    // Count positive, negative, zero
//    if (number > 0)
//        positive++;
//    else if (number < 0)
//        negative++;
//    else
//        zeros++;

//    // Count even and odd
//    if (number % 2 == 0)
//        even++;
//    else
//        odd++;

//    // Update max and min
//    if (number > max)
//        max = number;
//    if (number < min)
//        min = number;

//    // Sum of digits
//    int temp = Math.Abs(number);
//    while (temp > 0)
//    {
//        sumOfDigits += temp % 10;
//        temp /= 10;
//    }
//}

//// Output results
//Console.WriteLine("Negative = " + negative);
//Console.WriteLine("Positive = " + positive);
//Console.WriteLine("Zeros = " + zeros);
//Console.WriteLine("Even = " + even);
//Console.WriteLine("Odd = " + odd);
//Console.WriteLine("Max = " + max);
//Console.WriteLine("Min = " + min);
//Console.WriteLine("Sum of Digits = " + sumOfDigits);

// ##########################################################
// Task4

//// O'qish: avval N, keyin N ta element
//int n = int.Parse(Console.ReadLine());
//string[] input = Console.ReadLine().Split();
//int[] array = new int[n];

//for (int i = 0; i < n; i++)
//{
//    array[i] = int.Parse(input[i]);
//}

//// Juft indeksli elementlarni chiqarish
//for (int i = 0; i < n; i += 2)
//{
//    Console.Write(array[i] + " ");
//}

// ##########################################################
// Task5

//// O'qish: elementlar soni va o'zi
//int n = int.Parse(Console.ReadLine());
//string[] input = Console.ReadLine().Split();
//int[] array = new int[n];

//for (int i = 0; i < n; i++)
//{
//    array[i] = int.Parse(input[i]);
//}

//int count = 0;

//for (int i = 1; i < n; i++)
//{
//    if (array[i] > array[i - 1])
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);

// ##########################################################
// Task6

//int n = int.Parse(Console.ReadLine());
//string[] input = Console.ReadLine().Split();
//int[] array = new int[n];

//for (int i = 0; i < n; i++)
//{
//    array[i] = int.Parse(input[i]);
//}

//// Hisoblash va chiqarish
//for (int i = 0; i < n; i++)
//{
//    int count = 0;
//    for (int j = 0; j < n; j++)
//    {
//        if (array[i] == array[j])
//        {
//            count++;
//        }
//    }

//    if (count > 1)
//    {
//        Console.Write(array[i] + " ");
//    }
//}

// ##########################################################
// Task7

//Console.Write("From = ");
//int from = int.Parse(Console.ReadLine());

//Console.Write("To = ");
//int to = int.Parse(Console.ReadLine());

//for (int i = from; i <= to; i++)
//{
//    Console.WriteLine("-------------------------------");
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}x{j}= {i * j}");
//    }
//}
//Console.WriteLine("-------------------------------");

// ##########################################################
// Task8

//Console.Write("The first number is: ");
//double num1 = double.Parse(Console.ReadLine());

//Console.Write("The operation is: ");
//char operation = Console.ReadLine()[0];

//Console.Write("The second number is: ");
//double num2 = double.Parse(Console.ReadLine());

//double result = 0;
//bool validOperation = true;

//switch (operation)
//{
//    case '+':
//        result = Sum(num1, num2);
//        break;
//    case '-':
//        result = Subtract(num1, num2);
//        break;
//    case '*':
//        result = Multiplication(num1, num2);
//        break;
//    case '/':
//        if (num2 == 0)
//        {
//            Console.WriteLine("Error: Division by zero!");
//            validOperation = false;
//        }
//        else
//        {
//            result = Division(num1, num2);
//        }
//        break;
//    default:
//        Console.WriteLine("Invalid operation!");
//        validOperation = false;
//        break;
//}

//if (validOperation)
//    Console.WriteLine($"{num1} {operation} {num2} = {result}");
//    }

//    static double Sum(double a, double b)
//{
//    return a + b;
//}

//static double Subtract(double a, double b)
//{
//    return a - b;
//}

//static double Multiplication(double a, double b)
//{
//    return a * b;
//}

//static double Division(double a, double b)
//{
//    return a / b;
//}

// ##########################################################
// Task9

//Console.Write("Input the base value : ");
//int baseValue = int.Parse(Console.ReadLine());

//Console.Write("Input the exponent : ");
//int exponent = int.Parse(Console.ReadLine());

//long result = Power(baseValue, exponent);

//Console.WriteLine($"The value of {baseValue} to the power of {exponent} is : {result}");
//    }

//    static long Power(int baseValue, int exponent)
//{
//    if (exponent == 0)
//        return 1;
//    else if (exponent < 0)
//        throw new ArgumentException("Negative exponents are not supported in this implementation.");
//    else
//        return baseValue * Power(baseValue, exponent - 1);
//}

// ##########################################################
// Task10

Console.Write("Input number of terms for the Fibonacci series : ");
int n = int.Parse(Console.ReadLine());

Console.Write("The Fibonacci series of " + n + " terms is : ");

for (int i = 0; i < n; i++)
{
    Console.Write(Fibonacci(i) + " ");
}
    

    static int Fibonacci(int n)
{
    if (n == 0) return 0;
    else if (n == 1) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

// ##########################################################