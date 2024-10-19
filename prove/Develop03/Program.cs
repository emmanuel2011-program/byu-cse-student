using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        library.AddScripture(new Reference("John", 10, 30), "I and my Father are one.");
        library.AddScripture(new Reference("John", 11, 5), "Now Jesus loved Martha, and her sister, and Lazarus.");
        library.AddScripture(new Reference("Matthew", 10, 30), "But the very hairs of your head are numbered.");
        library.AddScripture(new Reference("Matthew", 10, 1), "And he had called unto him his disciples, he gave them power against unclean spirits...");
        library.AddScripture(new Reference("Luke", 5, 1), "And it came to pass, that, as the people pressed upon him to hear the word of God...");
        library.AddScripture(new Reference("Acts", 2, 1), "And when the day of Pentecost was fully come, they were all with one accord in one place.");
        library.AddScripture(new Reference("Romans", 6, 1, 2), "What shall we say then? Shall we continue in sin, that grace may abound?...");

        while (true)
        {
            Console.Clear();

            Scripture scripture = library.SelectRandomScripture();

            if (scripture != null)
            {
                // Display and interact with the selected scripture
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                    {
                        // Exit the program if 'quit' is typed
                        return;
                    }

                    scripture.HideNextWord();

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine("You've memorized the entire scripture!");
                        // Exit the inner loop
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}
