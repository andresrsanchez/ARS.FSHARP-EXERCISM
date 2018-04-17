// Learn more about F# at http://fsharp.org

open System
open System.Text.RegularExpressions

//let exercism_Year = 
//    printfn "Give me a year: "
//    let year = System.Console.ReadLine() |> int
//    printf "Result : %b" (year % 4 = 0 && year % 100 <> 0 && year % 400 = 0) //leap condition

let exercism_Bob = 
    while true do
        printfn "Tell me something: "
        let something = System.Console.ReadLine()
        let (|FirstRegexGroup|_|) pattern input =
            let m = Regex.Match(input,pattern) 
            if (m.Success) then Some m.Groups.[1].Value else None 
        match something with
        | FirstRegexGroup "^¿?(.*)\?" something -> printf "Sure."
        | FirstRegexGroup "^[A-Z]*$" something -> printf "Whoa, chill out!"
        | FirstRegexGroup "^¿?[A-Z]*\?" something -> printf "Calm down, I know what I'm doing!"
        | FirstRegexGroup "^$" something -> printf "Fine. Be that way!"
        | _ -> printfn "Whatever"
        printfn "%s" Environment.NewLine

[<EntryPoint>]
let main argv =
    exercism_Bob |> ignore
    Console.ReadLine() |> ignore
    0 // return an integer exit code

