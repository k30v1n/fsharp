#r "nuget:FSharp.Data"

open FSharp.Data
open System.IO

let getHtml (htmlFile: string) : HtmlDocument option =
    try
        let html = HtmlDocument.Load(htmlFile)
        Some(html)
    with
    | ex -> 
        // printfn $"Error: {ex}"
        None

HtmlDocument.Load "doesnotexist"

getHtml "doesnotexist"

let htmlPath = Path.Join(__SOURCE_DIRECTORY__, "index.html")

getHtml htmlPath

        