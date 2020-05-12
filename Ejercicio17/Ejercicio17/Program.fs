// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnNum num =
    match num with
    |num when num = -1 ->
        ()
    |_ -> 
        let cub = num*num*num
        printfn "Cubo %A" cub
        printfn "Número"
        let n = Convert.ToInt32(Console.ReadLine())
        fnNum n
        ()

printfn "Número"
let n = Convert.ToInt32(Console.ReadLine())
fnNum n