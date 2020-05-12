// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnGasto gasto sumagas =
    match gasto with
    |gasto when gasto = -1 ->
        printfn "Suma %A" sumagas
    |_ ->
        printfn "gasto"
        let g = Convert.ToInt32(Console.ReadLine())
        fnGasto g (sumagas+gasto)
        ()

printfn "gasto"
let gasto = Convert.ToInt32(Console.ReadLine())
fnGasto gasto 0