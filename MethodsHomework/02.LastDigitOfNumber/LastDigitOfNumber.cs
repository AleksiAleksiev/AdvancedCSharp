using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(number));
    }

    private static string GetLastDigitAsWord(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        string[] words = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        return words[lastDigit];
    }
}

