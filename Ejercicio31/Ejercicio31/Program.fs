// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnPrimo2 i band sp j =
    if j < (i/2) && band = 'v' then
        if (i % j) = 0 then
            fnPrimo2 i 'F' sp (j+2)
        else
            fnPrimo2 i 'v' sp (j+2)
    else
        if band = 'v' then
            printfn "Número primo: %A" i
            (sp+1)
        else 
            sp
        
let rec fnPrimo i m sp =
    match i with
    |i when i > m ->
        printfn "Entre 1 y M hay %A números primos" sp
    |_ ->
        let a = fnPrimo2 i 'v' sp 3
        fnPrimo (i+2) m a

let fnPrincipal m =
    if m >= 2 then
        printfn "Número primo: 1"
        printfn "Número primo: 2"
        fnPrimo 3 m 2
    else 
        if m >= 1 then
            printfn "Número primo: 1"
            fnPrimo 3 m 1
        else
            fnPrimo 3 m 0

printfn "Ingrese m"
let m = Convert.ToInt32(Console.ReadLine())
fnPrincipal m
