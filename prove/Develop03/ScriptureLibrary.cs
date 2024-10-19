using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public void AddScripture(Reference reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }

    public Scripture SelectRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("The scripture library is empty.");
            return null;
        }

        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
