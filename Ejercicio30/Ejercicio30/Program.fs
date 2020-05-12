open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let rec fnVinito2 i t1 t2 t3 t4 t5 mct2 totvin año j = 
    match j with
    |j when j > 5 ->
        printfn "Total de litros producidos por año: %A" totvin
        let tupla = (t1, t2, t3, t4, t5, mct2, año)
        tupla
    |_ ->
        printfn "Inserte cabtidad de vinito tipo%A" j
        let v = Convert.ToInt32(Console.ReadLine())
        match j with
        |1 ->
            fnVinito2 i (t1+v) t2 t3 t4 t5 mct2 (totvin+v) año (j+1)
        |2 -> 
            if v > mct2 then
                fnVinito2 i t1 (t2+v) t3 t4 t5 v (totvin+v) i (j+1)
            else
                fnVinito2 i t1 (t2+v) t3 t4 t5 mct2 (totvin+v) año (j+1)
        |3 ->
            if v = 0 then
                printfn "El año %A" i
                printfn "No se produjo vino tipo 3"
            fnVinito2 i t1 t2 (t3+v) t4 t5 mct2 (totvin+v) año (j+1)
        |4 ->
            fnVinito2 i t1 t2 t3 (t4+v) t5 mct2 (totvin+v) año (j+1)
        |5 ->
            fnVinito2 i t1 t2 t3 t4 (t5+v) mct2 (totvin+v) año (j+1)
        |_ ->
            (0,0,0,0,0,0,0)
            

let rec fnVinito (t1, t2, t3, t4, t5, mct2, añ) n i =
    match i with
    |i when i > n ->
        printfn "Total tipo1: %A" t1
        printfn "Total tipo2: %A" t2
        printfn "Total tipo3: %A" t3
        printfn "Total tipo4: %A" t4
        printfn "Total tipo5: %A\n" t5

        printfn "Año en que se produjo mayor cantidad de vino tipo2: %A" añ
        printfn "Litros: %A" mct2
    |_ ->
        let (tv1, tv2, tv3, tv4, tv5, mctv2, año) = fnVinito2 i t1 t2 t3 t4 t5 mct2 0 0 1
        fnVinito (tv1, tv2, tv3, tv4, tv5, mctv2, año) n (i+1)

printfn "Inserte n"
let n = Convert.ToInt32(Console.ReadLine())
fnVinito (0, 0, 0, 0, 0, 0, 0) n 1