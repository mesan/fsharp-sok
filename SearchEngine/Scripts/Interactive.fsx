#load @"load-project.fsx"
let fn = @"C:\Users\martin\Dropbox\Programming\faggruppe\fsharp-sok\SearchEngine\App_Data\Test.xml"
let parser = new XmlDataParser.WikiXmlParser(fn)
let doc = parser.parse |> Seq.exactlyOne
