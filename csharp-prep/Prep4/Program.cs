using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)

    {    
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber !=0)
        {  
            Console.WriteLine("enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            if (userNumber !=0)
            {    
                    numbers.Add(userNumber);
            }
               
               
               
        }  
        int sum = 0;
        foreach (int number in numbers) 
        { 
            sum += number;
        }
        Console.Write($"The sum is: {sum} 2");

        // computing the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // finding the max number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

            
    }
}