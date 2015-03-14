module XmlDataParser
open System.Xml.Linq
open System.IO
open WikiDocument

type WikiXmlParser() = 
    let ns : XNamespace =  XNamespace.Get "http://www.mediawiki.org/xml/export-0.10/";
    let page = ns + "page"
    let title = ns + "title"
    let text = ns + "text"
    let revision = ns + "revision"
    let fileName = @"C:\Users\martin\programming\faggruppe\fsharp-sok\SearchEngine\App_Data\wikipedia.xml"
    //let fileName = Directory.GetCurrentDirectory() + "\App_Data\Test.xml"
    let xmlDocument = XDocument.Load(fileName)

    member this.parse =
        query { 
            for document in xmlDocument.Descendants(page) do
            let doctitle = (document.Element title).Value
            let doctext = (document.Element revision).Element(text).Value
            select { title = doctitle; text = doctext; }
        }
