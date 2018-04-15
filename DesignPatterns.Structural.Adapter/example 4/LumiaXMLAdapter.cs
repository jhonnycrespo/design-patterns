using System.Xml;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.Adapter.example_4
{
    class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJsonAdaptee = new LumiaJSONAdaptee();

            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJSONSpecifications();

            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMoblies", true);

            return doc;
        }
    }
}
