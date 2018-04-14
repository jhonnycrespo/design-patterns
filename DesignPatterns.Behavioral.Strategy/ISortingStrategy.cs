using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface ISortingStrategy
    {
        void Sort<T>(List<T> dataToBeSorted);
    }
}
