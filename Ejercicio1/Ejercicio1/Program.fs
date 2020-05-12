open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


let fnMayor (n1, n2) = 
    if n1>n2 then printfn "Mayor = %A" n1 
    else printfn "Mayor = %A" n2

let n1 = Console.ReadLine()
let n2 = Console.ReadLine()

fnMayor (n1, n2)