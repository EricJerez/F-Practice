module Program

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    Code.Practice1.test()

    printfn "Press ENTER to continue..."
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code
