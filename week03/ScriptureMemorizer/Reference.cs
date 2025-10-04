public class Reference
{
    // Private Attributes [3]
    private string _book;
    private int _chapter;
    private int _verse; // Start verse
    private int _endVerse; 

    // Constructor 1: Single Verse [2]
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; // Set to 0 to indicate no range
    }

    // Constructor 2: Verse Range (Function Overloading) [1, 2]
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Behavior: GetDisplayText() [4]
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            // Example: "John 3:16"
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Example: "Proverbs 3:5-6"
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}