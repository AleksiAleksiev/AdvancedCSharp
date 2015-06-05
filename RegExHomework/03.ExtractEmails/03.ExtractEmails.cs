using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?(?=>@)[^@]+@[^@]+a|\d+)";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match item in matches)
        {
            Console.WriteLine(item);
        }

    }
}

