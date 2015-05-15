using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class MinMaxAverage
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<double> numbers = Console.ReadLine().Replace(",", ".").Split().Select(double.Parse).ToList();
        List<double> whole = numbers.Where(p => (int)p == p).ToList();
        List<double> floating = numbers.Where(p => (int)p != p).ToList();
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", 
            string.Join(", ", whole), whole.Min(), whole.Max(), whole.Sum(), whole.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
            string.Join(", ", floating), floating.Min(), floating.Max(), floating.Sum(), floating.Average());
    }
}

