﻿module Code

    module Practice1 =
        let pred n = n - 1 

        let test () = 
          printfn "The predecesor of 16 is %d" (pred 16) 

    module ProblemSet1Q1 =

        let test1 () = 
            printfn "The result of 2 + 5 * 10 is %d" (2 + 5 * 10) 

        let test2 () = 
            printfn "The result of 10I * 20I is %A" (10I * 20I)
    
        let test3 () = 
            printfn "The result of 4 + 5.6 is %d" (4 + 5)

        let test4() =
            let str1 = "4"
            let str2 = "5"
            printfn "The string is: %s" (str1 + str2)
    
    module Practice_Fib =
        let rec fib1 = function
        | 0 -> 0I
        | 1 -> 1I
        | n -> fib1(n-1) + fib1(n-2)
        
        printfn "Fib = %A" (fib1) 
        

        let rec fib2 n = 
            match n with
            |0 -> 0I
            |1 -> 1I
            |n -> fib1(n-1) + fib1(n-2)