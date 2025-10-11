using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string GetEntryAsString()
    {
        // Guardamos los datos separados por “|” para evitar problemas con comas
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length < 3)
        {
            return null;
        }
        return new Entry(parts[0], parts[1], parts[2]);
    }
}