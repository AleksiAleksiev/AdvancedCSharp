using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        int max = firstNumber;
        if (secondNumber > firstNumber)
        {
            max = secondNumber;
        }
        return max;
    }
}

