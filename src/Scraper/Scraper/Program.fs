open FSharp.Data

[<Literal>]
let url = "http://www.funda.nl/koop/utrecht/+5km/100000-300000/woonhuis/2+kamers/tuin/3-dagen/"

[<EntryPoint>]
let main argv = 

    let searchPage = HtmlDocument.Load(url)

    let results = searchPage.CssSelect "div.search-result-content"

    let links = results |> Seq.map (fun result -> result.Descendants ["a"] |> Seq.choose (fun link -> link.TryGetAttribute("href")) |> Seq.head)


    0 // return an integer exit code

