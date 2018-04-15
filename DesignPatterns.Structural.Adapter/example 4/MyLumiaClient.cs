using System.Xml;

namespace DesignPatterns.Structural.Adapter.example_4
{
    class MyLumiaClient
    {
        private ILumiaXMLTarget _lumiaXmlTarget;

        public MyLumiaClient(ILumiaXMLTarget lumiaXmlTarget)
        {
            _lumiaXmlTarget = lumiaXmlTarget;
        }

        public XmlDocument GetLumiaData()
        {
            return _lumiaXmlTarget.GetLumiaMobilesXMLSpecifications();
        }
    }
}
