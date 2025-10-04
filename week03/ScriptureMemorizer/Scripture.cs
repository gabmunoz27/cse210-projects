using System.Collections.Generic;
using System.Linq;
using System; 

public class Scripture
{
    // Private Attributes [6, 11]
    private Reference _reference;
    private List<Word> _words;
    
    // Constructor [10, 12]
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        // Encapsulation: The Scripture class handles turning the input string 
        // into a list of Word objects internally [10]
        _words = new List<Word>();
        
        // Split the text string into individual words
        string[] rawWords = text.Split(' ');
        
        foreach (string wordText in rawWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    // Behavior: HideRandomWords(numberToHide : int) [4]
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Find all words that are currently NOT hidden
        List<Word> availableWords = _words.Where(w => !w.IsHidden()).ToList();

        // If there are no words left to hide, we stop.
        if (availableWords.Count == 0)
        {
            return;
        }
        
        // Determine how many unique words we can actually hide
        int countToHide = Math.Min(numberToHide, availableWords.Count);

        for (int i = 0; i < countToHide; i++)
        {
            // Select a random index from the list of available (unhidden) words
            int index = random.Next(availableWords.Count);
            
            // Hide the selected word
            availableWords[index].Hide();
            
            // Remove the word from the list of available words 
            // so we don't accidentally select it again in this loop
            availableWords.RemoveAt(index);
        }
    }

    // Behavior: GetDisplayText() [4]
    public string GetDisplayText()
    {
        // 1. Get the reference display text
        string referenceDisplay = _reference.GetDisplayText();

        // 2. Build the scripture text by concatenating the display text of all individual words
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", displayWords);
        
        // 3. Combine reference and text for final display
        return $"{referenceDisplay} {scriptureText}";
    }

    // Behavior: IsCompletelyHidden() [4]
    public bool IsCompletelyHidden()
    {
        // Check if every word in the list is hidden
        return _words.All(w => w.IsHidden());
    }
}