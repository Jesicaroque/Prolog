open System
open System.Diagnostics

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let Cost (num : float) =
    printfn "Costo total de la llamada: %A" num

let fnClave (clave, num : float) =
    match clave with
    |12 ->
        Cost(num*2.0)
    |15 ->
        Cost(num*2.2)
    |18 ->
        Cost(num*4.5)
    |19 ->
        Cost(num*3.5)
    |23 ->
        Cost(num*6.0)
    |25 ->
        Cost(num*6.0)
    |29 ->
        Cost(num*5.0)
    |_ -> 
        Cost(0.0)

let datos () =
    printfn "Clave"
    let clave = Convert.ToInt32(Console.ReadLine())
    printfn "Minutos"
    let min = Convert.ToDouble(Console.ReadLine())
    let tupla = (clave, min)
    tupla

let (clav, num) = datos()
fnClave (clav, num)