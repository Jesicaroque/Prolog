// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnNum sumotr sumpos cuepos n i =
    match i with
    |i when i > n ->
        printfn "Cuepos %A" cuepos
        printfn "Propor %A" (sumpos/cuepos)
        printfn "Progen %A" ((sumpos+sumotr)/n)
    |_ ->
        let num = Convert.ToInt32(Console.ReadLine())
        if num > 0 then
            fnNum sumotr (sumpos+num) (cuepos+1) n (i+1)
        else
            fnNum (sumotr+num) sumpos cuepos n (i+1)

printfn "Ingrese N"
let n = Convert.ToInt32(Console.ReadLine())
fnNum 0 0 0 n 1