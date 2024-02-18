using System;
using System.Collections.Generic;

public static class ScriptureReference
{
    private static readonly Dictionary<string, string> ScriptureDictionary = new Dictionary<string, string>()
    {
        { Scriptures.GetJohn316(), "John 3:16" },
        { Scriptures.GetProverbs356(), "Proverbs 3:5-6" },
        { Scriptures.GetEther1227(), "Ether 12:27" },
        { Scriptures.GetLuke1234(), "Luke 12:34" },
        { Scriptures.GetFirstNephi2010(), "1 Nephi 20:10" },
        { Scriptures.GetMoroni1020(), "Moroni 10:20" }
    };


    public static string GetReference(string scriptureText)
    {
        Console.WriteLine($"Scripture text received: '{scriptureText}'");
        foreach (var pair in ScriptureDictionary)
        {
            Console.WriteLine($"Comparing scripture text: '{scriptureText}' with dictionary key: '{pair.Key}'");
            if (pair.Key.Equals(scriptureText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found!");
                return pair.Value;
            }
        }
        Console.WriteLine("No match found!");
        return "Unknown Reference";
    }


/*
    public static string GetReference(string scriptureText)
    {
        foreach (var pair in ScriptureDictionary)
        {
            Console.WriteLine($"Comparing scripture text: '{scriptureText}' with dictionary key: '{pair.Key}'");
            if (pair.Key.Equals(scriptureText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found!");
                return pair.Value;
            }
        }
        Console.WriteLine("No match found!");
        return "Unknown Reference";
    }
    */
}
