using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter.example_2
{
    /// <summary>
    /// The 'ITarget' interface
    /// </summary>
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}
