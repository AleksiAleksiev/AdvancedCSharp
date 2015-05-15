using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class EqualStrings
{
    static void Main()
    {
        List<string> strings = Console.ReadLine().Split().ToList();
        for (int i = 0; i < strings.Count - 1; i++)
        {
            if (strings[i] == strings[i + 1])
            {
                Console.Write(strings[i] + " ");
            }
            else
            {
                Console.WriteLine(strings[i]);
            }
        }
        Console.WriteLine(strings[strings.Count - 1]);
    }
}

