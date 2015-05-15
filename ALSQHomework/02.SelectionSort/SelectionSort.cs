using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SelectionSort
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int firstUnsorted = 0;
        while (firstUnsorted != numbers.Count - 1)
        {
            int min = numbers[firstUnsorted];
            int minIndex = firstUnsorted;
            for (int i = firstUnsorted + 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }
            if (min != numbers[firstUnsorted])
            {
                int temp = min;
                numbers[minIndex] = numbers[firstUnsorted];
                numbers[firstUnsorted] = temp;
            }
            firstUnsorted++;
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}

