#load @"load-project.fsx"

let fn = @"C:\Users\martin\programming\faggruppe\fsharp-sok\SearchEngine\App_Data\Test.xml"
let parser = new XmlDataParser.WikiXmlParser(fn)
let doc = parser.parse |> Seq.exactlyOne


type Document = {
    Name: string;
    Author: string;
    Rating: int option
}
