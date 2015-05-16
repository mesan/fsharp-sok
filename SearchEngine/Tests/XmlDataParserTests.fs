module XmlDataParserTests
open XmlDataParser

open NUnit.Framework

[<TestFixture>]
type XmlDataParserTest() =

    let fileName = @"C:\Users\martin\Dropbox\Programming\faggruppe\fsharp-sok\SearchEngine\App_Data\Test.xml"
    let parser = new WikiXmlParser(fileName)

    [<Test>]
    member test.Should_Create_A_single_document() =
        let docLength = parser.parse |> Seq.length
        Assert.That(docLength , Is.EqualTo(1))

    [<Test>]
    member test.Should_Create_a_document_with_the_correct_values() =
        let doc = parser.parse |> Seq.exactlyOne
        Assert.That(doc.id , Is.EqualTo(106))
        Assert.That(doc.title , Is.EqualTo("Bangladesh"))
        Assert.That(doc.text , Is.EqualTo("Tekst om Bangladesh"))
