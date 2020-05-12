// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open System

let rec fnNum num =
    match num with
    |num when num = 1 ->
        printfn "Num %A" num
    |_ ->
        printfn "Num %A" num
        if pown -1 num  > 0 then
            fnNum (num/2)
        else
            fnNum (num*3+1)

printfn "inserte número"
let num = Convert.ToInt32(Console.ReadLine())

if num > 0 then
    fnNum num
else
    printfn "El número debe de ser un entero positivo"