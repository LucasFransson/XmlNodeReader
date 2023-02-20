using System.Xml;

namespace Xml
{
    public class XmlNodeReader
    {
        public string GetNodeInnerTextFromString(string xmlString, string stringTargetNode)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);

            XmlNode targetNode = doc.SelectSingleNode(stringTargetNode);

            return targetNode.InnerText;
        }
        public string GetNodeTextFromFile(string filePath, string stringTargetNode)
        {
            return GetNodeTextValue(GetXmlNode(GetXmlDocFromFile(filePath), stringTargetNode));
        }

        public string GetNodeTextValue(XmlNode node)
        {
            return node.InnerText;
        }

        public XmlNode GetXmlNode(XmlDocument xmlDoc, string stringTargetNode)
        {
            return xmlDoc.SelectSingleNode(stringTargetNode);
        }

        public XmlDocument GetXmlDocFromFile(string filePath)
        {
            XmlDocument document = new();
            document.Load(filePath);
            return document;
        }
    }
}