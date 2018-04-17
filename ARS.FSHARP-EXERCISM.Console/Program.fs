// Learn more about F# at http://fsharp.org

open System
open System.Text.RegularExpressions

let exercism_OneFromBoth = 
    printfn "Give me a name: "
    let name = System.Console.ReadLine()
    let message addName = 
        printf "One for %s, one for me." addName
    if name = "" then message "you" else message name

let exercism_MultiplesSum = 
    printfn "Give me a number: "
    let number = System.Console.ReadLine() |> int
    let sum = ref 0
    for i in 1 .. number do
        if number % i = 0 then sum := !sum + i
    printf "%i" !sum

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

let exercism_Year = 
    printfn "Give me a year: "
    let year = System.Console.ReadLine() |> int
    printf "Result : %b" (year % 4 = 0 && year % 100 <> 0 && year % 400 = 0) //leap condition

[<EntryPoint>]
let main argv =
    Console.ReadLine() |> ignore
    0 // return an integer exit code

