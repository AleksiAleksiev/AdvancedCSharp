using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int length = numbers.Count;
        List<int> longest = new List<int>();
        List<int> current = new List<int>();
        current.Add(numbers[0]);
        for (int i = 1; i < length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                current.Add(numbers[i]);
                if (i != length - 1) continue;
            }
            if (current.Count > longest.Count)
            {
                longest = current.ToList();
            }
            Console.WriteLine(string.Join(" ", current));
            current.Clear();
            current.Add(numbers[i]);
            if (i == length - 1 && (numbers[i] <= numbers[i - 1]))
            {
                Console.WriteLine(numbers[i]);
            }

        }
        Console.WriteLine("Longest: " + string.Join(" ", longest));
    }
}

