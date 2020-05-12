open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let fnOrden (a, b, c) =
    match b with
    |b when a>b ->
        printfn "Los números no están en orden creciente"
    |b when b>c ->
        printfn "Los números no están en orden creciente"
    |_ -> 
        printfn "Los números están en orden creciente"

let datos =
    let a = Convert.ToInt32(Console.ReadLine())
    let b = Convert.ToInt32(Console.ReadLine())
    let c = Convert.ToInt32(Console.ReadLine())
    let tupla = (a,b,c)
    tupla

let (a,b,c) = datos
fnOrden(a,b,c)