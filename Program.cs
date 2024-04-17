using System.Xml;
using tp_lecture_xml_api;

Tools.ApiPath = "https://boardgamegeek.com/xmlapi/";
Tools.searchNamePath = "search?search=";
Tools.searchIdPath = "boardgame/";

// Partie 1 : Lire les titres du fichier XML

//string xmlFileName = "books.xml";
//string path = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\" + xmlFileName;

//XmlDocument xmlBookDoc = new XmlDocument();

//xmlBookDoc.Load(path);

//foreach (XmlNode node in xmlBookDoc.DocumentElement.ChildNodes)
//{
//    XmlNode firstChildNode = node.ChildNodes[0];
//    Console.WriteLine(firstChildNode.InnerText);
//}

//Partie 2 : Utiliser l'API BoardGameGeek rechercher des noms

//string apiPath = "https://boardgamegeek.com/xmlapi/";
//string searchNamePath = "search?search=";

//Console.Write("Ecrivez votre recherche : ");
//string searchName = Console.ReadLine();

//string path = apiPath + searchNamePath + searchName.ToLower();

//XmlDocument xmlApiDoc = new XmlDocument();

//xmlApiDoc.Load(path);

//foreach (XmlNode node in xmlApiDoc.DocumentElement.ChildNodes)
//{
//    XmlNode firstChildNode = node.ChildNodes[0];
//    Console.WriteLine(firstChildNode.InnerText);
//}

//Partie 3 : La même avec les ID

//string apiPath = "https://boardgamegeek.com/xmlapi/";
//string searchIDPath = "boardgame/";

//Console.Write("Ecrivez l'ID de votre recherche : ");
//string searchName = Console.ReadLine();

//string path = apiPath + searchIDPath + searchName;

//XmlDocument xmlApiDoc = new XmlDocument();

//xmlApiDoc.Load(path);

//XmlNode parentNode = xmlApiDoc.SelectSingleNode("/boardgames/boardgame");

//XmlNode childNode = parentNode.SelectSingleNode("name");

//Console.WriteLine(childNode.InnerText);

// Partie 4 : Reprendre la partie 2 et afficher l'ID, le nom et les auteurs/autrices (prit designer)

Console.Write("Ecrivez votre recherche : ");
string searchName = Console.ReadLine();

XmlDocument xmlFirstSearch = Tools.SearchName(searchName);

foreach (XmlNode node in xmlFirstSearch.DocumentElement.ChildNodes)
{
    string gameID = node.Attributes["objectid"].Value;
    
    Console.WriteLine($"-----\nId : {gameID}");
    Console.WriteLine("Title : " + Tools.PrintTitle(node));

    XmlDocument gameDetailsDoc = Tools.SearchId(gameID);

    string designerName = Tools.PrintDesigners(gameDetailsDoc);
    
    Console.WriteLine("Designer : " + designerName + "\n-----");
    
}



