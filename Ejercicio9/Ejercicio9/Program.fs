open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let IMP (imp, prebas) =
    let pretot = prebas + imp
    printfn "pretotal: %A" pretot
    printfn "PREBAS: %A" prebas

let fnPRE (prebas : float )=
    match prebas with
    |prebas when prebas>500.0 ->
        IMP (((20.0*0.30)+(prebas-40.0)*0.50), prebas)
    |prebas when prebas>40.0 ->
        IMP (((20.0*0.30)+(prebas-40.0)*0.40), prebas)
    |prebas when prebas>20.0 ->
        IMP ((prebas-40.0)*0.30, prebas)
    |_ ->
        IMP(0.0, prebas)

let datos ()=
    printfn "PREBAS"
    let p = Convert.ToDouble(Console.ReadLine())
    p

let prebas = datos()
fnPRE prebas