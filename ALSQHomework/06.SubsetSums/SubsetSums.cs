using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
        int numOfSubsets = 1 << numbers.Count;
        int counter = 0;
        for (int i = 1; i < numOfSubsets; i++)
        {
            int sum = 0;
            for (int j = 0; j < numbers.Count; j++)
            {
                if ((i & (1 << numbers.Count - 1 - j)) != 0)
                {
                    sum += numbers[j];
                }
            }
            if (sum == n)
            {
                counter++;
                List<int> foundSumElements = new List<int>();
                for (int j = 0; j < numbers.Count; j++)
                {
                    if ((i & (1 << numbers.Count - 1 - j)) != 0)
                    {
                        foundSumElements.Add(numbers[j]);
                    }
                }
                Console.WriteLine(string.Join(" + ", foundSumElements) + " = " + sum);
            }
        }
        if (counter ==0)
        {
            Console.WriteLine("No matching subsets.");
        }


    }
}

