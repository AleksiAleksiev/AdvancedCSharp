using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string word = Console.ReadLine();
        string input = Console.ReadLine();
        string pattern = string.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]", word);
        MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
        foreach (Match item in matches)
        {
            Console.WriteLine(item);
        }
    }
}

