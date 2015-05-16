module SearchEngine

open System.IO
open XmlDataParser
open WikiDocument


[<EntryPoint>]
let main argv = 
    let rawText = WikiXmlParser
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
