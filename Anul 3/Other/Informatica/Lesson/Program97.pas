Program P97;
type Natural=0..MaxInt;
var a : real;
b : Natural;
c : real;
s : integer;
t : integer;
v : real;

function Putere(x : real; n : Natural) : real;
var p : real;
i : integer;
begin
p:=1;
for i:=1 to n do p:=p*x;
Putere:=p;
end; 

begin
a:=3.0;
b:=2;
c:=Putere(a, b);
writeln(a:10:5, b:4, c:10:5);
s:=2;
t:=4;
v:=Putere(s, t);
writeln(s:5, t:4, v:10:5);
readln;
end.