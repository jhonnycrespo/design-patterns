using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class HeapSort : ISortingStrategy
    {
        public void Sort<T>(List<T> dataToBeSorted)
        {
            Console.WriteLine("sorting using heap sort");
        }
    }
}
