using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class MergeSort : ISortingStrategy
    {
        public void Sort<T>(List<T> dataToBeSorted)
        {
            Console.WriteLine("sorting using merge sort");
        }
    }
}
