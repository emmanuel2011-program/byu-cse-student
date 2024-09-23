using System;

class Program
{
    static void Main(string[] args)
    {  
        // display the welcome message
        DisplayWelcomeMessage();
        string userName = promptUserName();
        int userNumber = promptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        //use a function name called displayresult
        DisplayResult(userName, squaredNumber);




    }
    //display welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome, to my progrm");

    }
      // prompting user for name
    static string promptUserName()
    {
        Console.Write("pleasse enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
     // prompting user for number
    static int promptUserNumber()
    {
        Console.Write("Please enter a choice number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, The suare of your number entered is {square}");
    }

    
}