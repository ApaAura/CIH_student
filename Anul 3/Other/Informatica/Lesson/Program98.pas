Program P98;
function Factorial(n : 0..7) : integer;
var p, i : integer;
begin
p:=1;
for i:=1 to n do p:=p*i;
Factorial:=p;
end; 
begin
writeln(Factorial(4));
readln;
end.