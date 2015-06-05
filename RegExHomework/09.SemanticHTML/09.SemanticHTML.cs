using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class SemanticHTML
{
    static void Main()
    {
        string openPattern = @"( *?)<div\s+(.*?)(?:id|class)\s*?=\s*?""(.+?)""\s*(.*?)>";
        string closePattern = @"(\s*?)<\/div>\s*<!--\s*([a-z]+)\s*-->";
        string input = Console.ReadLine();
        while (input !="END")
        {
            string line = input;
            if (Regex.IsMatch(input, openPattern))
            {
                Match match = Regex.Match(input, openPattern);
                line = string.Format("{0}<{1} {2} {3}", match.Groups[1], match.Groups[2], match.Groups[3], match.Groups[4]).TrimEnd() + ">";
                line = Regex.Replace(line, @"(?<=<.*?)\s{2,}", " ");
            }
            else if (Regex.IsMatch(input, closePattern))
            {
                Match match = Regex.Match(input, closePattern);
                line = string.Format("{0}</{1}>", match.Groups[1], match.Groups[2]);
            }
            Console.WriteLine(line);
            input = Console.ReadLine();
        }
    }
}

