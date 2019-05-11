

let rec fib2 n = 
    match n with
    | 0 -> 0I
    | 1 -> 1I
    | n -> fib2(n-1) + fib2(n-2)
     
let rec fib1 = function
| 0 -> 0I
| 1 -> 1I
| n -> fib1(n-1) + fib1(n-2)

//fib2 13
fib1 13
