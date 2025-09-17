using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type numbers to add them to the list. Enter 0 to finish.");

        List<int> values = new List<int>();
        int input = -1;

        while (input != 0)
        {
            Console.Write("Number: ");
            string text = Console.ReadLine();
            input = int.Parse(text);

            if (input != 0)
            {
                values.Add(input);
            }
        }

        // --- Sum ---
        int total = 0;
        foreach (int val in values)
        {
            total += val;
        }
        Console.WriteLine($"Total: {total}");

        // --- Average ---
        float avg = (float)total / values.Count;
        Console.WriteLine($"Average: {avg}");

        // --- Max ---
        int biggest = values[0];
        foreach (int val in values)
        {
            if (val > biggest)
            {
                biggest = val;
            }
        }
        Console.WriteLine($"Highest number: {biggest}");

        // --- Stretch 1: Smallest positive number ---
        int smallestPositive = int.MaxValue;
        foreach (int val in values)
        {
            if (val > 0 && val < smallestPositive)
            {
                smallestPositive = val;
            }
        }

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"Smallest positive number: {smallestPositive}");
        }

        // --- Stretch 2: Sort the list ---
        values.Sort();
        Console.WriteLine("Numbers in ascending order:");
        foreach (int val in values)
        {
            Console.WriteLine(val);
        }
    }
}