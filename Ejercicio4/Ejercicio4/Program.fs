open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let fnOp op =
    match op with
    |"a" -> printfn "Android"
    |"i" -> printfn "iOS"
    |_ -> printfn "Inválida"

let op = Console.ReadLine()
printf "Su opción es "
fnOp op