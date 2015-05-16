module SearchEngine

open System.IO
open XmlDataParser
open WikiDocument

[<EntryPoint>]
let main argv = 
    let wikiXmlParser = new WikiXmlParser(@"C:\Users\martin\Dropbox\Programming\faggruppe\fsharp-sok\SearchEngine\App_Data\wikipedia.xml")
    let wikiDocuments = wikiXmlParser.parse

    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
