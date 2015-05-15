using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArray
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        numbers.Sort();
        Console.WriteLine(string.Join(", ", numbers));
    }
}

