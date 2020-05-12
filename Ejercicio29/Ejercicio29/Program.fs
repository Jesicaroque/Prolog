// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnClave ap1 ap2 ap3 ap4 ap5 recau (p1, p2, p3, p4, p5, clave, can) =
    match clave with
    |clave when (clave = -1) && (can = -1) ->
        printfn "Cantidad boletos tipo1 %A" ap1
        printfn "Cantidad boletos tipo2 %A" ap2
        printfn "Cantidad boletos tipo3 %A" ap3
        printfn "Cantidad boletos tipo4 %A" ap4
        printfn "Cantidad boletos tipo5 %A" ap5
        printfn "Recaudación del estado %A" recau
    |_ ->
        printfn "\nCantidad %A" can
        printfn "Clave %A" clave
        printfn "Pre %A\n" (p1*can)
        printfn "Insertar clave"
        let cl = Convert.ToInt32(Console.ReadLine())
        printfn "Insertar can"
        let cn = Convert.ToInt32(Console.ReadLine())
        
        match clave with
        |1 -> fnClave (ap1+can) ap2 ap3 ap4 ap5 (recau+(p1*can)) (p1, p2, p3, p4, p5, cl, cn)
        |2 -> fnClave ap1 (ap2+can) ap3 ap4 ap5 (recau+(p2*can)) (p1, p2, p3, p4, p5, cl, cn)
        |3 -> fnClave ap1 ap2 (ap3+can) ap4 ap5 (recau+(p3*can)) (p1, p2, p3, p4, p5, cl, cn)
        |4 -> fnClave ap1 ap2 ap3 (ap4+can) ap5 (recau+(p4*can)) (p1, p2, p3, p4, p5, cl, cn)
        |5 -> fnClave ap1 ap2 ap3 ap4 (ap5+can) (recau+(p5*can)) (p1, p2, p3, p4, p5, cl, cn)
        |_ -> ()

let datos () =
    printfn "P1"
    let p1 = Convert.ToInt32(Console.ReadLine())
    printfn "P2"
    let p2 = Convert.ToInt32(Console.ReadLine())
    printfn "P3"
    let p3 = Convert.ToInt32(Console.ReadLine())
    printfn "P4"
    let p4 = Convert.ToInt32(Console.ReadLine())
    printfn "P5"
    let p5 = Convert.ToInt32(Console.ReadLine())
    printfn "Clave 1-5"
    let clave = Convert.ToInt32(Console.ReadLine())
    printfn "Cantidad"
    let can = Convert.ToInt32(Console.ReadLine())
    let tupla = (p1, p2, p3, p4, p5, clave, can)
    tupla

let (p1, p2, p3, p4, p5, clave, can) = datos()
fnClave 0 0 0 0 0 0 (p1, p2, p3, p4, p5, clave, can)