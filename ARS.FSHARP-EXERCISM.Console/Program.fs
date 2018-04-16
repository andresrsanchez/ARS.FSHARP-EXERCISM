// Learn more about F# at http://fsharp.org

open System

let exercism_Year = 
    printfn "Give me a year: "
    let year = System.Console.ReadLine() |> int
    printf "Result : %b" (year % 4 = 0 && year % 100 <> 0 && year % 400 = 0) //leap condition
    Console.ReadLine() |> ignore

[<EntryPoint>]
let main argv =
    exercism_Year |> ignore
    0 // return an integer exit code

