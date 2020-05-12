open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

(*let fnCalor TA =
    if TA = "si" then printfn "Vestir ropa deportiva e ir al parque"
    else printfn "Vestir informalmente e ir al cine"

let fnComp com =
    if com = "si" then printfn "Usar el carro"
    else printfn "Usar el transporte publico"

printfn "Hace calor?"
let TA = Console.ReadLine()
printfn "Tengo compañia?"
let com = Console.ReadLine()

fnCalor TA
fnComp com*)

// ----- Con Match -----

let fnComp com =
    match com with
    |"si" -> printfn "Usar el carro"
    |_ -> 
        printfn "Usar el transporte publico"

let fnCalor TA =
    match TA with
    |"si" -> printfn "Vestir ropa deportiva e ir al parque"
    |_ -> 
        printfn "Tengo compañia?"
        let com = Console.ReadLine()
        printfn "Vestir informalmente e ir al cine"
        fnComp com

printfn "Hace calor?"
let TA = Console.ReadLine()

fnCalor TA