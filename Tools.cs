using System.Xml;

namespace tp_lecture_xml_api;

public static class Tools
{
    public static string ApiPath { get; set; }
    public static string searchNamePath { get; set; }
    public static string searchIdPath { get; set; }

    public static XmlDocument SearchName(string searchNameString)
    {
        string path = ApiPath + searchNamePath + searchNameString;
        
        XmlDocument xmlApiDoc = new XmlDocument();
        xmlApiDoc.Load(path);

        return xmlApiDoc;
    }
    
    public static XmlDocument SearchId(string searchIdString)
    {
        string path = ApiPath + searchIdPath + searchIdString;
        
        XmlDocument xmlApiDoc = new XmlDocument();
        xmlApiDoc.Load(path);

        return xmlApiDoc;
    }

    public static string PrintTitle(XmlNode xmlNode)
    {
        XmlNode titleChildNode = xmlNode.SelectSingleNode("name");

        return titleChildNode.InnerText;
    }

    public static string PrintDesigners(XmlDocument xmlDocument)
    {
        XmlNode gameParentNode = xmlDocument.SelectSingleNode("");

        XmlNode gameChildNode = gameParentNode.SelectSingleNode("boardgamedesigner");

        return gameChildNode.InnerText;
    }
}