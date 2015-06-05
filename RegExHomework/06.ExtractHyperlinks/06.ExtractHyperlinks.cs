using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a.*?(?<!"">)href\s*?=\s*?([""'])?(\S.*?)(?:>|class|\1)";
        while (input.Substring(input.Length - 3) != "END")
        {
            input += Console.ReadLine();
        }
        input = input.Remove(input.Length - 3);
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match item in matches)
        {
            Console.WriteLine(Regex.Replace(item.Groups[2].Value, @"\s{2,}", " "));
        }
    }
}

