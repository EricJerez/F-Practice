
let list1 = [1;2;3;4;5]
let list2 = [6;7;8;9;10]


let rec add a b =
    match a, b with
    | [], [] -> []
    | a::atail, b::btail -> (a + b) :: (add atail btail) 

add list1 list2