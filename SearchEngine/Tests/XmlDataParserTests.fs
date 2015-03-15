module XmlDataParserTests
open XmlDataParser

open NUnit.Framework

[<TestFixture>]
type XmlDataParserTest() =

    let fileName = @"C:\Users\martin\programming\faggruppe\fsharp-sok\SearchEngine\App_Data\Test.xml"
    let parser = new WikiXmlParser(fileName)

    [<Test>]
    member tests.Removing_Curly_Bracket() =
        let doc = parser.parse |> Seq.nth(0)
        Assert.That(doc.text, Is.EqualTo("Denne teksten skal bort"))

    [<Test>]
    member tests.Removing_Triple_Apostrophe() =
        let doc = parser.parse |> Seq.nth(1)
        Assert.That(doc.text, Is.EqualTo("Trippel apostrof skal fjernes"))

    [<Test>]
    member tests.Removing_HTML_Entities() =
        let doc = parser.parse |> Seq.nth(2)
        Assert.That(doc.text, Is.EqualTo("Disse skal bort"))
