using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string first = Console.ReadLine();
        Console.WriteLine(first);
        Console.Write("What is your last last? ");
        string last = Console.ReadLine();
        Console.WriteLine(last);
        Console.WriteLine($"your name is {first} {last}");
        
        
    
    }
}
