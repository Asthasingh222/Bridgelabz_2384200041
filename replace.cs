using System;
using System.Text.RegularExpressions;

class SpaceReplacer
{
    // Method to replace multiple spaces with a single space
    public string ReplaceSpaces(string text)
    {
        return Regex.Replace(text, @"\s+", " ");
    }

    static void Main()
    {
        string text = "This    is   an   example  with   multiple   spaces.";
        SpaceReplacer replacer = new SpaceReplacer();
        string result = replacer.ReplaceSpaces(text);
        Console.WriteLine("Processed Text: " + result);
    }
}
