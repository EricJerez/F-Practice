
let averageFour (a, b, c, d) =
   let sum = a + b + c + d
   sum / 4.0

let avg:float = averageFour (4.0, 10.0, 20.0, 12.0)

let swap (a,b ) = (b,a)

swap (2131, "Hello")

fst(swap(2131, "Hello"))
snd(swap(2131, "Hello"))

let list1 = [(1,2) ; (2,3) ; (5,6)]

list1.Length

let r1 = list1 |> List.map (fun (x,y) -> swap(x,y))

let list2 = [(8,2) ; (2,3) ; (5,1)]
let r2 = list2 |> List.sort

let r3 = list1 |> List.append list2
