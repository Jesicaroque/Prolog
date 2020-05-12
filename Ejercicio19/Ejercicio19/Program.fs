// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open System

let rec fnSum band sumser i =
    printfn"Esto es i %A" i
    match i with
    |i when i > 1800 ->
        printfn "Sumser %A" sumser
    |_->
        printfn "inserte i"
        let g = Convert.ToInt32(Console.ReadLine())
        if band = 'T' then
            fnSum 'F' (sumser+1) (g+3)
        else
            fnSum 'T' (sumser+1) (g+2)

fnSum 'T' 0 2