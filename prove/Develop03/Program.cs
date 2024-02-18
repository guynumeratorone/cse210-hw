using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        bool quit = false;
        Word currentWord = null;
        Random random = new Random();

        do
        {
            Console.WriteLine("Which scripture would you like to work on?");
            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. Proverbs 3:5-6");
            Console.WriteLine("3. Ether 12:27");
            Console.WriteLine("4. Luke 12:34");
            Console.WriteLine("5. 1 Nephi 20:10");
            Console.WriteLine("6. Moroni 10:20");
            Console.WriteLine("7. Randomize Scripture");
            Console.WriteLine("8. Quit");

            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    currentWord = new Word(Scriptures.GetJohn316());
                    break;

                case "2":
                    currentWord = new Word(Scriptures.GetProverbs356());
                    break;

                case "3":
                    currentWord = new Word(Scriptures.GetEther1227());
                    break;

                case "4":
                    currentWord = new Word(Scriptures.GetLuke1234());
                    break;

                case "5":
                    currentWord = new Word(Scriptures.GetFirstNephi2010());
                    break;

                case "6":
                    currentWord = new Word(Scriptures.GetMoroni1020());
                    break;

                case "7":
                    int randomScriptureIndex = random.Next(1, 7);
                    string randomScripture = "";
                    switch (randomScriptureIndex)
                    {
                        case 1:
                            randomScripture = Scriptures.GetJohn316();
                            break;
                        case 2:
                            randomScripture = Scriptures.GetProverbs356();
                            break;
                        case 3:
                            randomScripture = Scriptures.GetEther1227();
                            break;
                        case 4:
                            randomScripture = Scriptures.GetLuke1234();
                            break;
                        case 5:
                            randomScripture = Scriptures.GetFirstNephi2010();
                            break;
                        case 6:
                            randomScripture = Scriptures.GetMoroni1020();
                            break;
                    }
                    currentWord = new Word(randomScripture);
                    break;

                case "8":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                    break;
            }
                        if (currentWord != null)
{
    string reference = ScriptureReference.GetReference(currentWord.OriginalText);
    Console.WriteLine($"{reference} {currentWord.GetMaskedText()}");
    Console.WriteLine("Press Enter to reveal a random word or type 'quit' to exit.");
    while (true)
    {
        string input = Console.ReadLine();
        if (input.ToLower() == "quit")
        {
            quit = true;
            break;
        }
        else
        {
            string maskedWord = currentWord.MaskRandomWord();
            if (maskedWord != null)
            {
                Console.WriteLine($"{reference} {currentWord.GetMaskedText()}");
            }
            else
            {
                Console.WriteLine("No more words to mask.");
                break;
            }
                    }
                }
            }

            currentWord = null;
            if (!quit)
            {
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        } 
        while (!quit);
    }
}
