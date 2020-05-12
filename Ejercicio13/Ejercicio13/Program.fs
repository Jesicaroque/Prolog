open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let fnImp (cos) =
    printfn "Costo total %A" cos

let Costo(cos, edad) =
    if 14<=edad 
    then if edad<=22 
         then fnImp(cos*1.10) 
         else fnImp(cos*1.0)
    else fnImp(cos*1.0)

let fnTiEn (tipo, edad, dias) =
    match tipo with
    |1 ->
        Costo(dias*25.0,edad)
    |2 ->
        Costo(dias*16.0,edad)
    |3 ->
        Costo(dias*20.0,edad)
    |4 ->
        Costo(dias*32.0,edad)
    |_ ->
        Costo(0.0,edad)

let datos () =
    printfn "Tipo enf"
    let t = Convert.ToInt32(Console.ReadLine())
    printfn "Edad"
    let e = Convert.ToInt32(Console.ReadLine())
    printfn "Dias"
    let d = Convert.ToDouble(Console.ReadLine())
    let tupla = (t,e,d)
    tupla

let (tipo, edad, dias) = datos()
fnTiEn (tipo, edad, dias)