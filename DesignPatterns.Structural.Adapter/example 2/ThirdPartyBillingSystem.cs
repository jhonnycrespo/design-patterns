using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter.example_2
{
    /// <summary>
    /// The 'Client' class
    /// </summary>
    class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");

            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}
