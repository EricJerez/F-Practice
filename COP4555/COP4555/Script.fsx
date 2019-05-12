
let rec fact1 x =
    if x < 1 then 1
    else x * fact1 (x - 1)

fact1 4

let rec fact2 x =
    match x with
    | 0 -> 1
    | 1 -> 1
    | x -> x * fact1 (x-1)

fact2 4

let rec fact3 = 
    fun x -> x * fact1 (x-1)

fact3 4