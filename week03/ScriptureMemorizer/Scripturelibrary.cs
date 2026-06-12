using System;
using System.Collections.Generic;

/// <summary>
/// Manages a collection of scriptures and picks one at random.
/// Exceeds core requirements: provides a library instead of a single hardcoded scripture.
/// </summary>
public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _random = new Random();
        _scriptures = new List<Scripture>();
        LoadScriptures();
    }

    /// <summary>
    /// Populates the library with well-known scriptures.
    /// Demonstrates both single-verse and verse-range Reference constructors.
    /// </summary>
    private void LoadScriptures()
    {
        _scriptures.Add(new Scripture(
            new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness I give unto men weakness that they may be humble and my grace is sufficient for all men that humble themselves before me for if they humble themselves before me and have faith in me then will I make weak things become strong unto them"
        ));

        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
        ));

        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
        ));

        _scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"
        ));

        _scriptures.Add(new Scripture(
            new Reference("Joshua", 1, 9),
            "Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest"
        ));

        _scriptures.Add(new Scripture(
            new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be and men are that they might have joy"
        ));
    }

    /// <summary>Returns a randomly selected scripture from the library.</summary>
    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}