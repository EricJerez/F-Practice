module Program

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    //Code.Practice1.test()

    Code.ProblemSet1Q1.test1()
    Code.ProblemSet1Q1.test2()
    Code.ProblemSet1Q1.test3()
    Code.ProblemSet1Q1.test4()
   
    printfn "Press ENTER to continue..."
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code
