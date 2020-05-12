open System
open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let rec fnSue (sue:float) nom =
    match sue with
    |sue when sue = -1.0 ->
        printfn "Nom %A" nom
    |_ -> 
        if sue < 1000.0 then
            let msue = sue*1.15
            printfn "Msue %A" msue
            let su = Convert.ToDouble(Console.ReadLine())
            fnSue su (nom+msue)
        else
            let msue = sue*1.12
            printfn "Msue %A" msue
            let su = Convert.ToDouble(Console.ReadLine())
            fnSue su (nom+msue)

let sue = Convert.ToDouble(Console.ReadLine())
fnSue sue 0.0
