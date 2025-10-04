public class Word
{
    // Private Attributes [3, 6]
    private string _text;
    private bool _isHidden; 

    // Constructor: Sets initial state (not hidden) [2]
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Visibility set to shown by default [2]
    }

    // Behavior: Hide() [4, 7]
    public void Hide()
    {
        _isHidden = true;
    }

    // Behavior: Show() [4, 7]
    public void Show()
    {
        _isHidden = false;
    }

    // Behavior: IsHidden() [4, 7]
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Behavior: GetDisplayText() [4, 7]
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Returns underscores equal to the word's length [8]
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}