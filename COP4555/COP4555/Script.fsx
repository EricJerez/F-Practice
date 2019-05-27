
  type Student =
    {First_Name: string;
     Last_name: string;
     Student_id: int;
     Age: int;}


   let p = {Age = 15; 
            First_Name = "David";
            Last_name = "Perez"; 
            Student_id = 5851900};;

   let q = {Age = 22;
            First_Name = "Eric";
            Last_name = "Jerez"; 
            Student_id = 1234567};;

    let r = {Age = 23;
             First_Name = "Ere";
             Last_name = "Jeds"; 
             Student_id = 7894561};;

    let s = {Age = 26;
             First_Name = "Ed";
             Last_name = "Jer"; 
             Student_id = 4568912};;

let list = [p;q;r;s]


let rec apprev = function
| ([],    ys) -> ys
| (x::xs, ys) -> apprev(xs, x::ys)

let rev xs = apprev(xs, [])

rev list