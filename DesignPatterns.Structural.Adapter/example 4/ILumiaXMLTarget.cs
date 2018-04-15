using System.Xml;

namespace DesignPatterns.Structural.Adapter.example_4
{
    interface ILumiaXMLTarget
    {
        XmlDocument GetLumiaMobilesXMLSpecifications();
    }
}
