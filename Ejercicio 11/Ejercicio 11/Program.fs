open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let MSUE msue =
    printfn "MSUE %A" msue

let PME (pme, sue, me) =
    match me with
    |me when me>30 ->
        MSUE(sue+30*pme)
    |_ ->
        MSUE(sue+me*pme)

let fnCate (sue, cate, me) =
    match cate with
    |1 ->
        PME(30, sue, me)
    |2 ->
        PME(38, sue, me)
    |3 ->
        PME(50, sue, me)
    |4 ->
        PME(70, sue, me)
    |_ -> 
        PME(0, sue, me)

let datos () =
    printfn "SUE"
    let s = Convert.ToInt32(Console.ReadLine())
    printfn "CATE"
    let c = Convert.ToInt32(Console.ReadLine())
    printfn "ME"
    let h = Convert.ToInt32(Console.ReadLine())
    let tupla = (s, c, h)
    tupla

let (sue, cate, me) = datos()
fnCate (sue, cate, me)