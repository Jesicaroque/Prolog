open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let fnNota nota =
    match nota with
    |nota when nota < 3.0 -> printfn "Insuficiente"
    |nota when nota <= 3.5 -> printfn "Aceptable"
    |nota when nota <= 4.0 -> printfn "Sobresaliente"
    |_ -> printfn "Excelente"


let nota = Convert.ToDouble(Console.ReadLine())
printf "Su nota es "
fnNota nota