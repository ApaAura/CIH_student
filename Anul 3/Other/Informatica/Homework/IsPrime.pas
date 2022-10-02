Program Primechk; 
Var 
Num                     :       Integer; 
checker,count,adder     :       ShortInt; 
Begin 
 Write('Enter one number : '); 
 Readln(Num); 
 adder := 0; 
 For count := 1 to 10 do 
   begin 
     checker := num mod count; 
     if checker = 0 then 
     adder := adder + 1 
   end; 
 if (num <= 10) and (adder > 2) then 
    Writeln(num, ' is not a prime number') 
 else 
     if (num > 10) and (adder > 1) then 
        Writeln(num, ' is not a prime number') 
     else 
         Writeln(num,' is a prime number'); 
end. 