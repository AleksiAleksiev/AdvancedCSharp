using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(\w)(?:\1*)";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match item in matches)
        {
            Console.Write(item.Groups[1]);
        }
        Console.WriteLine();
        //string input = Console.ReadLine();   //variant 2
        //string pattern = @"(\w)(?:\1*)";
        //Regex regex = new Regex(pattern);
        //Console.WriteLine(regex.Replace(input, "$1"));
    }
}

