#load @"load-project.fsx"

let parser = new XmlDataParser.WikiXmlParser()
let docs = parser.parse
