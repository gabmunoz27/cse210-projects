using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");
        Console.WriteLine($".........");

        foreach (string word in words)
        {
            Console.WriteLine($"Equip: {word}");
        }
        Console.WriteLine($"........."); 
    }
}