// ####################################################################################

// ### Task1
//int n = 12345;

//int Even = EvenCount(n);
//int Odd = OddCount(n);
//int Count = DigitCount(n);
//int Sum = SumDigit(n);

//Console.WriteLine($"Even:{Even}");
//Console.WriteLine($"Odd:{Odd}");
//Console.WriteLine($"Count:{Count}");
//Console.WriteLine($"Sum:{Sum}");


//static int EvenCount(int n) 
//{
//    int count = 0;
//    while (n > 0)
//    {
//        int digit = n % 10;
//        if (digit % 2 == 0)
//        {
//            count++;
//        }
//        n /= 10;
//    }
//    return count;
//}

//int OddCount(int n) 
//{
//    int count = 0;
//    while(n > 0)
//    {
//        int digit = n % 10;
//        if (digit % 2 != 0) 
//        {
//            count++;
//        }
//        n /= 10;
//    }
//    return count;
//}

//int DigitCount(int n) 
//{
//    int count = 0;
//    while (n > 0) 
//    {
//        int digit = n % 10;
//        count++;
//        n /= 10;
//    }
//    return count;
//}

//int SumDigit(int n) 
//{
//    int sum = 0;
//    while (n > 0)
//    {
//        int digit = n % 10;
//        sum += digit;
//        n /= 10;
//    }
//    return sum;
//}

// #################################################################################### 

// ### Task2
//int a = 8, b = 4;

//int add = Addnumber(a, b);
//int subtract = Subtract(a, b);
//int multiply = Multiply(a, b);
//int division = Division(a, b);

//Console.WriteLine($"Add:{add}");
//Console.WriteLine($"Subtract:{subtract}");
//Console.WriteLine($"Multiply:{multiply}");
//Console.WriteLine($"Division:{division}");

//static int Addnumber(int a, int b)
//{
//    return a + b;
//}

//static int Subtract(int a, int b)
//{
//    return a - b;
//}

//static int Multiply(int a, int b)
//{
//    return a * b;
//}

//static int Division(int a, int b) 
//{
//    return a / b;
//}

// ####################################################################################

// ### Task3
//int n = 1234;

//int min = MinDigit(n);
//int max = MaxDigit(n);

//Console.WriteLine($"{min} + {max} = {min + max}");

//static int MinDigit(int n) 
//{
//    int min = 9;
//    while (n > 0) 
//    {
//        int digit = n % 10;
//        if (digit < min) 
//        {
//            min = digit;
//        }
//        n /= 10;
//    }
//    return min;
//}

//static int MaxDigit(int n) 
//{
//    int max = -1;
//    while (n > 0) 
//    {
//        int digit = n % 10;
//        if (digit > max) 
//        {
//            max = digit;
//        }
//        n /= 10;
//    }
//    return max;
//}

// ####################################################################################

// ### Task4
//int x = 2, y = 3;
//int natija = PowSum(x, y);
//Console.WriteLine(natija);

//static int PowSum(int x, int y) 
//{
//    return (int)Math.Pow(x, y);
//}

// ####################################################################################

// ### Task5
//int x = 5, y = 10;

//Swap(ref x, ref y);
//Console.WriteLine($"x = {x}");
//Console.WriteLine($"y = {y}");

// void Swap(ref int a, ref int b) 
//{
//    int c;
//    c = a;
//    a = b;
//    b = c;
//}

// ####################################################################################

// ### Task6
//int x = 8;
//Divisors(x);

//static int Divisors(int x) 
//{
//    for (int i = 1; i <= x; i++) 
//    {
//        if (x % i == 0) 
//        { 
//            Console.Write(i + " ");
//        }
//    }
//    return 0;
//}

// ####################################################################################

// ### Task7
//int[] arr = new int[] { 1, 2, 3 };
//IncrementArrayElements(arr, 5);

//void IncrementArrayElements(int[] arr, int value) 
//{
//    for (int i = 0; i < arr.Length; i++) 
//    {
//        arr[i] += value;
//    }

//    Console.Write("[");
//    for (int i = 0; i < arr.Length; i++) 
//    {
//        Console.Write(arr[i]);
//        if (i < arr.Length - 1) 
//            Console.Write(",");
//    }
//    Console.Write("]");
//}

// ####################################################################################

// ### Task8
//int a = 1, b = 2, c = 3, d = 4;
//int min = MinNumber(a, b, c, d);

//Console.WriteLine(min);

//static int MinNumber(int a, int b, int c, int d) 
//{
//    int min = a;
//    if (min > b)
//    {
//        return b;
//    }
//    else if (min > c)
//    {
//        return c;
//    }
//    else if (min > d)
//    {
//        return d;
//    }
//    else
//    {
//        return a;
//    }
//}

// ####################################################################################

// ### Task9
//int val1 = 2, val2 = 1;
//int natija = Min(val1, val2);
//Console.WriteLine(natija);

//static int Min(int val1, int val2) 
//{
//    return (val1 < val2) ? val1 : val2;
//}

// ####################################################################################

// ### Task10
//int val1 = 2, val2 = 1;
//int natija = Max(val1, val2);
//Console.WriteLine(natija);

//static int Max(int val1, int val2) 
//{
//    return (val1 > val2) ? val1 : val2;
//}

// ####################################################################################