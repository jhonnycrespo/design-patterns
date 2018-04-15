using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter.example_1
{
    // the adapter
    class VendorAdapter : ITarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.GetListOfProducts();
        }
    }
}
