using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };

        int max = list.Max();
        Console.WriteLine("Largest number: " + max);

        list = list.Distinct().ToList();

        list.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < 0)
                list[i] = 0;
        }

        Console.WriteLine("Final list: " + string.Join(", ", list));
    }
}
