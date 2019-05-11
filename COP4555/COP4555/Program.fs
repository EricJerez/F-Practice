module Program

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    printfn "The predecesor of 16 is %d" (Code.Practice1.pred 16)

    printfn "Press ENTER to continue..."
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code
