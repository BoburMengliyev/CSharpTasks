// ####################################################################################

// ### Task1
//Console.WriteLine("Son kiriting: ");
//double a = Convert.ToDouble(Console.ReadLine());

//if (a <= 100)
//{
//    double foiz = (a * 5) / 100;
//    Console.WriteLine(a + foiz);
//}
//else if (a > 100 && a <= 200)
//{
//    double foiz1 = (a * 7) / 100;
//    Console.WriteLine(a + foiz1);
//}
//else if (a > 200) 
//{
//    double foiz2 = (a * 10) / 100;
//    Console.WriteLine(a + foiz2);
//}

// ####################################################################################

// ### Task2
//Console.WriteLine("Massiv hajmini kiriting? ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv elementlarini kiriting? ");
//string[] input = Console.ReadLine().Split();
//int[] arr = new int[a];
//int result = 1;
//bool hasZero = false;

//for (int i = 0; i < a; i++)
//{
//    arr[i] = Convert.ToInt32(input[i]);
//    if (arr[i] == 0) hasZero = true;
//}

//string expression = "";
//for (int i = 0; i < a; i++)
//{
//    int val = arr[i];
//    if (val < 0)
//    {
//        expression += $"({val})";
//    }
//    else expression += val;

//    if (i < a - 1) expression += "*";

//    if (!hasZero) result *= val;
//}

//if (hasZero) result = 0;

//Console.WriteLine($"{expression} = {result}");

// ####################################################################################

// ### Task3
//Console.WriteLine("Massiv hajmini kiriting? ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv elementlarini kiriting? ");
//string[] input = Console.ReadLine().Split();
//int[] arr = new int[a];

//for (int i = 0; i < a; i++) 
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//int max = arr[0];
//int maxindex = 0;
//for (int i = 0; i < a; i++) 
//{
//    if (arr[i] > max) 
//    {
//        max = arr[i];
//        maxindex = i;
//    }
//}

//Console.WriteLine($"Max element index: {maxindex}");

// ####################################################################################

// ### Task4
//Console.WriteLine("Massiv hajmini kiriting? ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv elementlarini kiriting? ");
//string[] input = Console.ReadLine().Split();
//int[] arr = new int[n];

//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//for (int i = 0; i < n; i++) 
//{
//    int count = 0;
//    for (int j = 0; j < n; j++) 
//    {
//        if (arr[i] == arr[j]) 
//        {
//            count++;
//        }
//    }
//    if (count == 1) 
//    {
//        Console.Write(arr[i] + " ");
//    }
//}

// ####################################################################################

// ### Task5
//Console.WriteLine("Massiv hajmini kiriting? ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv elementlarini kiriting? ");
//string[] input = Console.ReadLine().Split();
//int[] arr = new int[a];

//for (int i = 0; i < a; i++)
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//int min = arr[0];
//int minindex = 0;
//for (int i = 0; i < a; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//        minindex = i;
//    }
//}

//Console.WriteLine($"Max element index: {minindex}");

// ####################################################################################

// ### Task6
//Console.WriteLine("Massiv hajmini kiriting? ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv elementlarini kiriting? ");
//string[] input = Console.ReadLine().Split();
//int[] arr = new int[a];

//for (int i = 0; i < a; i++)
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//int count = 0;
//for (int i = 0; i < a - 2; i++) 
//{
//    if (arr[i] < arr[i + 1] && arr[i + 1] > arr[i + 2]) 
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Massivdagi qatiy katta qo`shni sonlar soni: {count}");

// ####################################################################################

// ### Task7

//Console.WriteLine("Arrey elementlarini kiriting:");
//string[] input = Console.ReadLine().Split();
//int[] arr = new int[input.Length];

//for (int i = 0; i < input.Length; i++)
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//int birinchi = 0;
//int ikkinchi = 0;
//bool found = false;

//for (int i = 0; i < arr.Length - 1; i++) 
//{
//    if ((arr[i] > 0 && arr[i + 1] > 0) || (arr[i] < 0 && arr[i + 1] < 0)) 
//    {
//        birinchi = arr[i];
//        ikkinchi = arr[i + 1];
//        found = true;
//    }
     
//}
//if (found)
//{
//    Console.WriteLine($"{birinchi} {ikkinchi}");
//}

// ####################################################################################

// ### Task8
//Console.WriteLine("Massiv Hajmini kiriting: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv Elementlarini kiriting: ");
//string[] input = Console.ReadLine().Split();

//int[] arr = new int[a];

//for (int i = 0; i < a; i++) 
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//for (int i = 0; i < arr.Length; i++) 
//{
//    if (arr[i] % 2 != 0) 
//    {
//        Console.Write(i + " ");
//    }
//}

// ####################################################################################

// ### Task9

//Console.WriteLine("Massiv Hajmini kiriting: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv Elementlarini kiriting: ");
//string[] input = Console.ReadLine().Split();

//Console.WriteLine("Massiv a dan b gacha kiriting: ");

//int[] arr = new int[n];

//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//for (int i = a; i <= b; i++) 
//{
//    if (arr[i] % 2 != 0) 
//    {
//        Console.WriteLine($"Natija = {arr[i]}");
//    }
//}

// ####################################################################################

// ### Task10

//Console.WriteLine("Massiv hajmini kiriting? ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Massiv elementlarini kiriting? ");
//string[] input = Console.ReadLine().Split();
//int[] arr = new int[a];

//for (int i = 0; i < a; i++)
//{
//    arr[i] = Convert.ToInt32(input[i]);
//}

//for (int i = 0; i < a; i++) 
//{
//    if (arr[i] % 2 != 0)
//    {
//        Console.Write(Math.Pow(arr[i], 2) + " ");
//    }
//}

string