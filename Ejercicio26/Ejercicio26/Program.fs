// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec fnVoto (can1:float) (can2:float) (can3:float) (can4:float) voto =
    match voto with
    |voto when voto = 0.0 ->
        printf "Votos candidato1 %A    " can1
        printfn "Porcentaje  %A" ((can1/(can1+can2+can3+can4))*100.0)
        printf "Votos candidato2 %A    " can2 
        printfn "Porcentaje  %A" ((can2/(can1+can2+can3+can4))*100.0)
        printf "Votos candidato3 %A    " can3 
        printfn "Porcentaje  %A" ((can3/(can1+can2+can3+can4))*100.0)
        printf "Votos candidato4 %A    " can4 
        printfn "Porcentaje  %A" ((can4/(can1+can2+can3+can4))*100.0)
        printfn "Cantidad de votantes %A" (can1+can2+can3+can4)
    |_ ->
        printfn "Voto"
        let v = Convert.ToDouble(Console.ReadLine())
        match voto with
        |1.0 -> fnVoto (can1+1.0) can2 can3 can4 v
        |2.0 -> fnVoto can1 (can2+1.0) can3 can4 v
        |3.0 -> fnVoto can1 can2 (can3+1.0) can4 v
        |4.0 -> fnVoto can1 can2 can3 (can4+1.0) v
        |_ -> ()

printfn "Voto"
let voto = Convert.ToDouble(Console.ReadLine())
fnVoto 0.0 0.0 0.0 0.0 voto