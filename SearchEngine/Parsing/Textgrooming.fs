module Textgrooming
open System.Text.RegularExpressions

let replaceWithNothing text = Regex.Replace(text, "==|'''|{{.*}}|\n|<|>|\"|&", "")