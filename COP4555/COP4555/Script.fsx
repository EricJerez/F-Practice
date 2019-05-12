
let list1 = [1;2;3;4;5]
let list2 = [6;7;8;9;10]

let rec sum list = 
    match list with
    | [] -> 0
    | x :: xs -> x + sum xs

sum list1
