// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnSue masue manum n i =
    match i with
    |i when i > n ->
        printfn "Manum: %A" manum
        printfn "Masue: %A" masue
    |_ -> 
        printfn "Numemp"
        let numemp = Convert.ToInt32(Console.ReadLine())
        printfn "Sue"
        let sue = Convert.ToInt32(Console.ReadLine())
        if sue > masue then
            fnSue sue numemp n (i+1)
        else
            fnSue masue manum n (i+1)

printfn "Num"
let n = Convert.ToInt32(Console.ReadLine())
fnSue 0 0 n 1
