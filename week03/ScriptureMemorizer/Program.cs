using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Initialize the scripture object
        
        // Example Reference: handling a verse range
        Reference reference = new Reference("Ether", 12, 27); 
        string text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";
        
        // Main Loop: Continues until user types 'quit' or scripture is completely hidden
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            // 2. Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // 3. Prompt the user
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            // 4. Hide words if the user pressed Enter
            if (userInput == "")
            {
                // Hides 3 random unhidden words each time
                scripture.HideRandomWords(3); 
            }
        }
        
        // Final Display (showing all words hidden, if applicable)
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nWell done.");
    }
}