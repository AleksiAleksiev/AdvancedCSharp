using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class ReverseNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string number = Console.ReadLine();
        double reversed = GetReversedNumber(number);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(string number)
    {
        number = number.Replace(',', '.').Replace('-','\0');
        char[] reverseSymbols = number.ToCharArray().Reverse().ToArray();
        double reversed = double.Parse(new string(reverseSymbols));
        return reversed;
    }
}

