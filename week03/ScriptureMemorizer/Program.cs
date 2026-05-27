// CSE 210 - Week 03: Scripture Memorizer
// ============================================================
//
// EXCEEDS CORE REQUIREMENTS:
//
// 1. SCRIPTURE LIBRARY: Instead of a single hardcoded scripture, the program
//    uses a ScriptureLibrary class that stores multiple scriptures and picks
//    one at random each time the program runs. This simulates a real memorization
//    tool where the user gets a different challenge each session.
//
// 2. SMART WORD HIDING: Scripture.HideRandomWords() only selects from words
//    that are NOT already hidden, guaranteeing consistent progress every round
//    and preventing wasted turns on already-hidden words.
//
// 3. VERSE RANGE SUPPORT: Reference supports both "John 3:16" (single verse)
//    and "Proverbs 3:5-6" (verse range) via constructor overloading.
//
// ============================================================
 
using System;
 
class Program
{
    static void Main(string[] args)
    {
        // Use the library to pick a random scripture each session
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();
 
        string userInput = "";
 
        // Main Loop: Continues until user types 'quit' or scripture is completely hidden
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
 
            // Prompt the user
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine() ?? "";
 
            // Hide words if the user pressed Enter
            if (userInput == "")
            {
                // Hides 3 random unhidden words each time
                scripture.HideRandomWords(3);
            }
        }
 
        // Final Display (showing all words hidden, if applicable)
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nWell done!");
    }
}