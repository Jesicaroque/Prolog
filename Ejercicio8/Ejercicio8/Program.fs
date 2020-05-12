open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let compra (pago : float) =
    printfn "Pago: %A" pago

let fnCompra (num : float) =
    match num with
    |num when num<500.0 ->
        compra (num)
    |num when num<=1000.0 ->
        compra (num-num*0.05)
    |num when num<=7000.0 ->
        compra (num-num*0.11)
    |num when num<=15000.0 ->
        compra (num-num*0.18)
    |_ ->
        compra (num-num*0.25)
  
let num () = 
    printfn "Valor de la compra "
    let num = Convert.ToDouble(Console.ReadLine())
    num

let n = num()
fnCompra n
