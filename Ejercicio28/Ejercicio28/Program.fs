// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnLluvia arsu arno arce mersu mes i =
    match i with
    |i when i > 5 ->
        printfn "Promedio región centro: %A" (arce/12)
        printfn "Mes con menor lluvia reg sur: %A" mes
        printfn "Registro del mes: %A" mersu

        if arno > arce then
            if arno > arsu then
                printfn "La región con mayor lluvia  es la región norte"
            else
                printfn "La región con mayor lluvia  es la región sur"
        else
            if arce > arsu then
                printfn "La región con mayor lluvia  es la región centro"
            else
                printfn "La región con mayor lluvia  es la región sur"
    |_ ->
        printfn "Rno"
        let rno = Convert.ToInt32(Console.ReadLine())
        printfn "Rce"
        let rce = Convert.ToInt32(Console.ReadLine())
        printfn "Rsu"
        let rsu = Convert.ToInt32(Console.ReadLine())

        if rsu < mersu then
            fnLluvia (arsu+rsu) (arno+rno) (arce+rce) rsu i (i+1)
        else
            fnLluvia (arsu+rsu) (arno+rno) (arce+rce) mersu mes (i+1)

fnLluvia 0 0 0 50000 0 1