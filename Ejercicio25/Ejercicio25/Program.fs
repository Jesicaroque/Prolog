// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnsig pri seg sg i =
    match i with
    |i when i > 180.0 ->
        printfn "Sig %A" sg
    |_ ->
        //printfn "Sig %A" sg
        fnsig seg sg (pri+seg) (i+1.0)

fnsig 0.0 1.0 0.0 3.0