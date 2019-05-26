
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

   let list = [p;q]