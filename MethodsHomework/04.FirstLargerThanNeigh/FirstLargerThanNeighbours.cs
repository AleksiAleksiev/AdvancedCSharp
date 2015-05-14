using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int result = -1;
        for (int i = 0; i < numbers.Count; i++)
        {
            result = IndexFirstLargerThanNeigbours(numbers, i);
            if (result != -1)
            {
                Console.WriteLine(result);
                return;
            }
        }
        Console.WriteLine(result);
    }

    private static int IndexFirstLargerThanNeigbours(List<int> numbers, int i)
    {
        if (numbers.Count == 1)
        {
            return -1;
        }
        if (i == 0)
        {
            return (numbers[i] > numbers[i + 1]) ? 0 : -1;
        }
        if (i == numbers.Count - 1)
        {
            return (numbers[i] > numbers[i - 1]) ? i : -1;
        }
        if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
        {
            return i;
        }
        else
        {
            return -1;
        }
    }
}

