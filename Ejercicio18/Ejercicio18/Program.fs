// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnSuma par imp cuep i =
    match i with 
    |i when i>270 ->
        printfn "Promedio par: %A" (par/cuep)
        printfn "Suma impar: %A" imp
        ()
    |_ ->
        printfn "Insertar número"
        let n = Convert.ToInt32(Console.ReadLine())
        if n <> 0 then
            if pown -1 n > 0 then
                fnSuma (par+n) imp (cuep+1) (i+1)
            else 
                fnSuma par (imp+n) cuep (i+1)
        else
            fnSuma par imp cuep (i+1)

fnSuma 0 0 0 1