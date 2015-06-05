using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main()
    {
        string input = "<ul><li> <a href=http://softuni.bg>SoftUni</a> </li></ul>";
        //string input = Console.ReadLine();
        Console.WriteLine(input);
        string pattern = @"<a(.*?)>(.*?)<\/a>";
        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.Replace(input, "[URL$1]$2[/URL]"));
    }
}

