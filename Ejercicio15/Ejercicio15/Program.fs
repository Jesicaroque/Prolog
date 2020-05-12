// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System



let rec fnCuecer n i cuecer =
    match i with
    |i when i > n ->
        printfn "Cuecer: %A" cuecer
    |_ -> 
        printfn "Número"
        let num = Convert.ToInt32(Console.ReadLine())
        if num = 0 then
            fnCuecer n (i+1) (cuecer+1)
            ()
        else
            fnCuecer n (i+1) cuecer
            ()

printfn "Máximo"
let n = Convert.ToInt32(Console.ReadLine())
fnCuecer n 1 0