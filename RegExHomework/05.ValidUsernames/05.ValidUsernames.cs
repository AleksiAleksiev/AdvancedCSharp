using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class ValidUsernames
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<=^| |\/|\\|\(|\))[A-Za-z]\w{2,24}(?=$| |\/|\\|\(|\))";
        Regex regex = new Regex(pattern);
        MatchCollection match = regex.Matches(input);
        int index = 0;
        int maxLength = 0;
        for (int i = 0; i < match.Count - 1; i++)
        {
            if (match[i].Length + match[i+1].Length > maxLength)
            {
                maxLength = match[i].Length + match[i + 1].Length;
                index = i;
            }
        }
        Console.WriteLine(match[index]);
        Console.WriteLine(match[index + 1]);
    }
}

