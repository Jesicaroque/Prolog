open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let fnPar a =
    match a with
    |0 -> printfn "Nulo"
    |a when a%2 = 0 -> printfn "Par"
    |_ -> printfn "Impar"

let a = Convert.ToInt32(Console.ReadLine())
fnPar a