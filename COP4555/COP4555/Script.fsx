

let rec fib2 n = 
    match n with
    | 0 -> 0I
    | 1 -> 1I
    | n -> fib2(n-1) + fib2(n-2)

    fib2 6 