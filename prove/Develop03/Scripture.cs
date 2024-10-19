using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    public Reference Reference { get; }
    private int _currentWordIndex = 0;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');

        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideNextWord()
    {
        if (_currentWordIndex < _words.Count)
        {
            _words[_currentWordIndex].Hide();
            _currentWordIndex++;
        }
    }

    public bool IsCompletelyHidden()
    {
        return _currentWordIndex >= _words.Count;
    }

    public string RenderScripture()
    {
        string renderedText = string.Join(" ", _words);
        return $"{Reference}: {renderedText}";
    }
}
