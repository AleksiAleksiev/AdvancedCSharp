using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class UseYourChainsBuddy
{
    static void Main()
    {
        string input = Console.ReadLine();
        Match match = Regex.Match(input, @"(?<=<p>).*?(?=<\/p>)", RegexOptions.Singleline);
        string output = string.Empty;
        string temp;
        while (match.Success)
        {
            temp = Regex.Replace(match.Value, @"[^a-z\d\s]", " ");


            //temp = Regex.Replace(temp, @"[a-z]", x => (x.Value.CompareTo("m") <= 0 ? (char)(x.Value[0] + 13) : (char)(x.Value[0] - 13)).ToString());
            temp = Regex.Replace(temp, @"[a-z]", delegate(Match match2)
            {
                if (match2.Value.CompareTo("m") <= 0)
                {
                    return ((char)(match2.Value[0] + 13)).ToString();
                }
                else
                {
                    return ((char)(match2.Value[0] - 13)).ToString();
                }
            });
            temp = Regex.Replace(temp, @"\s{2,}", " ");
            output += temp;
            match = match.NextMatch();
        }
        Console.WriteLine(output);
    }
}

