using System;
using System.Collections.Generic;

class PromptGenerator
{
  public static string GetRandomPrompt()
  {
    List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was a small act of kindness I witnessed or experienced today?",
            "What experience or challenges did you feel you overcome today.",
            "Write down six things your learned today.",
            "Who is your motivator for this sweek.",
            "Where would you love to take your next vacation.",
            "Whta new thing did you learn today."
        };

    Random random = new Random();
    int index = random.Next(prompts.Count);
    return prompts[index];
  }
}