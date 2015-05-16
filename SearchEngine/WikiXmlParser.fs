module XmlDataParser
open System.Xml.Linq
open System.IO
open WikiDocument

type WikiXmlParser(fileName: string) = 

    let ns : XNamespace =  XNamespace.Get "http://www.mediawiki.org/xml/export-0.10/";
    let page = ns + "page"
    let id = ns + "id"
    let title = ns + "title"
    let text = ns + "text"
    let revision = ns + "revision"
    let xmlDocument = XDocument.Load(fileName)

    member this.parse =
        query { 
            for document in xmlDocument.Descendants(page) do
            let docid = int(document.Element(id).Value)
            let doctitle = (document.Element title).Value.Trim()
            let doctext = (document.Element revision).Element(text).Value.Trim()
            select { id = docid; title = doctitle; text = doctext; }
        }