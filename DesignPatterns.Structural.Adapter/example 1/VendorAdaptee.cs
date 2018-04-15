using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter.example_1
{
    // the class we want to adapt
    public class VendorAdaptee
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();

            products.Add("Gaming Consoles");
            products.Add("Television");
            products.Add("Books");
            products.Add("Musical Instruments");

            return products;
        }
    }
}
