open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let rec fnBand (serie:double) band (n:double) (i:double) =
    match i with
    |i when i > n ->
        printfn "%A" serie
    |_ ->
        if band = 'T' then
            fnBand (serie+(1.0/i)) 'F' n (i+1.0)
        else
            fnBand (serie-(1.0/i)) 'T' n (i+1.0)

printfn "Inserte n"
let n = Convert.ToDouble(Console.ReadLine())
fnBand 0.0 'T' n 1.0