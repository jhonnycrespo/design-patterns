using System;
using System.Xml;
using DesignPatterns.Structural.Adapter.example_1;
using DesignPatterns.Structural.Adapter.example_2;
using DesignPatterns.Structural.Adapter.example_3;
using DesignPatterns.Structural.Adapter.example_4;

namespace DesignPatterns.Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1

            example_1.ITarget adapter = new VendorAdapter();

            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }


            // Example 2

            example_2.ITarget adapter2 = new EmployeeAdapter();

            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(adapter2);

            client.ShowEmployeeList();

            // Example 3

            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Example 4

            ILumiaXMLTarget lumiaXmladapter = new LumiaXMLAdapter();
            XmlDocument lumiaXmlData = lumiaXmladapter.GetLumiaMobilesXMLSpecifications();
        }
    }
}
