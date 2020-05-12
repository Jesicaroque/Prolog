open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


//LAS FUNCIONES RECURSIVAS LEVAN "REC"    >:v

let rec fnNomina nom i =
    match i with
    |i when i >= 10 -> 
        printfn "Nomina %A" nom
    |_ -> 
        printfn "Sueldo"
        let sue = Convert.ToInt32(Console.ReadLine())
        fnNomina (nom+sue) (i+1)
        ()

fnNomina 0 0