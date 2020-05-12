open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let fnSem (sem, prom, mat, carr) s p =
    match sem with
    |sem when sem >= s ->
        if prom >= p
        then printf "Materia: %A "mat
             printfn "Carrera: %A Aceptado"carr
    |_ ->
        printfn ""

let fnSem2 (sem, prom, mat, carr) s p =
    match sem with
    |sem when sem > s ->
        if prom > p
        then printf "Materia: %A "mat
             printfn "Carrera: %A Aceptado"carr
    |_ ->
        printfn ""

let fnCarr (mat, carr, sem, prom) =
    match carr with
    |"Economia" ->
        fnSem(sem, prom, mat, carr) 6 8.8
    |"Computacion" ->
        fnSem2(sem, prom, mat, carr) 6 8.5
    |carr when carr = "Administracion" || carr = "Contabilidad" ->
        fnSem2(sem, prom, mat, carr) 5 8.5
    |_ ->
        printfn ""
    

let datos () =
    printfn "Materia"
    let m = Convert.ToString(Console.ReadLine())
    printfn "Carrera"
    let c = Convert.ToString(Console.ReadLine())
    printfn "Semestre"
    let s = Convert.ToInt32(Console.ReadLine())
    printfn "Promedio"
    let p = Convert.ToDouble(Console.ReadLine())
    let tupla = (m, c, s, p)
    tupla

let (mat, carr, sem, prom) = datos()
fnCarr(mat, carr, sem, prom)