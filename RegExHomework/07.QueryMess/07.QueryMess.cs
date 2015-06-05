using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();
        while (input != "END")
        {
            input = Regex.Replace(input, @"\+|%20", " ");
            Regex regex = new Regex(@"(?<=^|\?|&)\s*([^?&]+?)\s*=\s*([^?&]+?)\s*(?=$|\?|&)");
            MatchCollection matches = regex.Matches(input);
            string fixedKey;
            string fixedValue;
            foreach (Match item in matches)
            {
                fixedKey = Regex.Replace(item.Groups[1].Value, @"\s{2,}", " ");
                fixedValue = Regex.Replace(item.Groups[2].Value, @"\s{2,}", " ");
                if (!pairs.ContainsKey(fixedKey))
                {
                    pairs.Add(fixedKey, new List<string>());
                }
                pairs[fixedKey].Add(fixedValue);
                
            }
            foreach (var item in pairs)
            {
                Console.Write(item.Key + "=[{0}]", string.Join(", ", item.Value));
            }
            Console.WriteLine();
            pairs.Clear();
            input = Console.ReadLine();
        }
    }
}

