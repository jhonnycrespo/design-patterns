using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class QuickSort : ISortingStrategy
    {
        public void Sort<T>(List<T> dataToBeSorted)
        {
            Console.WriteLine("Sorting using quick sort");
        }
    }
}
