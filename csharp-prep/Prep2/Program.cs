using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";


        string sign = "";

        int lastdigit = percent % 10;
        
        if (percent >=90)
        {     letter = "A";
       
        }
        else if (percent >=80)
        {   letter = "B";
        }

        else if (percent >=70)
        {   letter = "C";
        }
        else if (percent >=60)
        {   letter = "D";
        }

        else {
            letter ="F";
        }
        if (lastdigit >=7)
        {   sign = "+";
        }
        else if (lastdigit <=3)
        {   sign = "-";
        }
        else {
            sign = "";
        }
        if (lastdigit >=93)
            {sign = "";
            
            }

            if (letter == "F")
             {    sign = "";
                }
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >=70)
        {   Console.WriteLine("passed");
        }
        else {
            Console.WriteLine("better luck next time");
        }

       
    }



    
}