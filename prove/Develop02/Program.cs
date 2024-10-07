using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal = new Journal();
        bool isContinue = true;
        while (isContinue)
        {

         Console.WriteLine("\nJournal Menu:");
         Console.WriteLine("1. Write a new entry");
         Console.WriteLine("2. Dispaly the Journal:");
         Console.WriteLine("3. Save the Journal to a file:");
         Console.WriteLine("4. load the Journal to a file");
         Console.WriteLine("5. Exit");
         
         Console.Write("Please select an option From this list:");
        
        string choice = Console.ReadLine();
          switch (choice)
      {
        case "1":
          string prompt = PromptGenerator.GetRandomPrompt();
          Console.WriteLine($"Prompt: {prompt}");
          Console.Write("Enter your response: ");
          string response = Console.ReadLine();
          Journal.AddEntry(prompt, response);
          break;


        case "2":
          if (Journal.EntriesCount() == 0)
          {
              Console.WriteLine("The journal is empty. Add some entries first.");
          }
          else
          {
              Journal.DisplayEntries();
          }
          break;


        case "3":
          Console.Write("Enter the file name to save: ");
          string saveFileName = Console.ReadLine();
          Journal.SaveToFile(saveFileName);
          Console.WriteLine("Journal saved successfully.");
          break;

        case "4":
          Console.Write("Enter the file name to load: ");
          string loadFileName = Console.ReadLine();
          Journal.LoadFromFile(loadFileName);
          Console.WriteLine("Journal loaded successfully.");
          break;

        case "5":
          isContinue = false;
          break;

        default:
          Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
          break;
      }
    }
  }
}








    
    
