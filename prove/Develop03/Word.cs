using System;
using System.Linq;

class Word
{
    public string OriginalText { get; }
    private string text;
    private string[] words;

    public Word(string text)
    {
        this.text = text;
        this.words = text.Split();
    }

public string MaskRandomWord()
{
    if (words.Length == 0)
        return null;

    Random rand = new Random();
    int wordIndex = rand.Next(0, words.Length);
    string word = words[wordIndex];

    // Create a masked word by replacing each letter with an underscore
    char[] maskedWord = new char[word.Length];
    for (int i = 0; i < word.Length; i++)
    {
        maskedWord[i] = '_';
    }

    // Replace all occurrences of the selected word with the masked word
    int startIndex = 0;
    while ((startIndex = text.IndexOf(word, startIndex)) != -1)
    {
        text = text.Remove(startIndex, word.Length).Insert(startIndex, new string(maskedWord));
        startIndex += maskedWord.Length; // Move to the next occurrence
    }

    // Remove the selected word from the list
    words = words.Where((source, index) => index != wordIndex).ToArray();

    // Check if there are any words left
    if (words.Length == 0)
        return null; // Return null if there are no more words to mask

    return word; // Return the original word (for user reference)
}
    public string GetMaskedText()
    {
        Console.Clear();
        return text;
    }
}

