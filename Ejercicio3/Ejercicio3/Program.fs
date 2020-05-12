open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


let fnDatos =
    printfn "Hace calor?"
    let TA = Console.ReadLine()
    printfn "Tengo compañia?"
    let com = Console.ReadLine()
    let tupla = (TA, com)
    tupla

let fnComp com =
    match com with
    |"si" -> printfn "Usar el carro\n"
    |_ -> 
        printfn "Usar el transporte publico\n"

let fnCalor TA =
    match TA with
    |"si" -> printfn "\nVestir ropa deportiva e ir al parque"
    |_ -> printfn "\nVestir informalmente e ir al cine"


let (TA, com) = fnDatos
fnCalor TA
fnComp com
