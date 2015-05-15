using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberCalc
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        //List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
        Console.WriteLine(Min(numbers));
        Console.WriteLine(Max(numbers));
        Console.WriteLine(Sum(numbers));
        Console.WriteLine(Avg(Sum(numbers), numbers.Count));
        Console.WriteLine(Prod(numbers));

    }

    private static double Prod(List<double> numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Count; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    private static decimal Prod(List<decimal> numbers)
    {
        decimal product = 1;
        for (int i = 0; i < numbers.Count; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    private static double Avg(double sum, int count)
    {
        return sum / count;
    }

    private static decimal Avg(decimal sum, int count)
    {
        return sum / count;
    }

    private static double Sum(List<double> numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    private static decimal Sum(List<decimal> numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    private static double Max(List<double> numbers)
    {
        double max = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    private static decimal Max(List<decimal> numbers)
    {
        decimal max = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    private static double Min(List<double> numbers)
    {
        double min = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    private static decimal Min(List<decimal> numbers)
    {
        decimal min = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
}

