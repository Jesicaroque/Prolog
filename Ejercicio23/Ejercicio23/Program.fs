open System
open System
open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let rec fnRombito med chi gra n i =
    match i with
    |i when i > n ->
        printfn "Chica %A" chi
        printfn "Meiana %A" med
        printfn "Grande %A" gra
    |_ ->
        let v = Convert.ToInt32(Console.ReadLine())
        match v with
        |v when v <= 200 ->
            fnRombito med (chi+1) gra n (i+1)
        |v when v < 400 ->
            fnRombito (med+1) chi gra n (i+1)
        |_ ->
            fnRombito med chi (gra+1) n (i+1)

printfn "Ingrese n"
let n = Convert.ToInt32(Console.ReadLine())
fnRombito 0 0 0 n 1