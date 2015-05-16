module TextgroomingTests
open NUnit.Framework

[<TestFixture>]
type TextgroomingTest() =
    [<Test>]
    member tests.Removing_Curly_Bracket() =
        let text = "Denne teksten {{inni her}} skal bort"
        Assert.That(text, Is.EqualTo("Denne teksten skal bort"))

    [<Test>]
    member tests.Removing_Triple_Apostrophe() =
        let text = "Trippel '''apostrof''' skal fjernes"
        Assert.That(text, Is.EqualTo("Trippel apostrof skal fjernes"))