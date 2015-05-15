using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(IsLargerThanNeigbours(numbers, i));
        }
    }

    private static string IsLargerThanNeigbours(List<int> numbers, int i)
    {
        if (numbers.Count == 1)
        {
            return "There are no neighbours.";
        }
        if (i == 0)
        {
            return (numbers[i] > numbers[i + 1]) ? "True" : "False";
        }
        if (i == numbers.Count - 1)
        {
            return (numbers[i] > numbers[i -1]) ? "True" : "False";
        }
        if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i -1])
        {
            return "True";
        }
        else
        {
            return "False";
        }
    }
}

