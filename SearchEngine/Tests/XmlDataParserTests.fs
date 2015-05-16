module XmlDataParserTests
open XmlDataParser

open NUnit.Framework

[<TestFixture>]
type XmlDataParserTest() =

    let fileName = @"C:\Users\martin\programming\faggruppe\fsharp-sok\SearchEngine\App_Data\Test.xml"
    let parser = new WikiXmlParser(fileName)

