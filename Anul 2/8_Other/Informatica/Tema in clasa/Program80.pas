Program P1;
{Sortare prin metoda bulelor}
const nmax=100;
type Tablou = array[1..nmax] of integer;
var A, B :Tablou;
n,i,j:integer;
x: integer;
begin
write('Dati numarul de componente n= ');
readln(n);
writeln('Dati componentele tabloului A:');
for i:=1 to n do read(A[i]);
readln;
B:=A;
for i:=1 to n-1 do
for j:=i+1 to n do 
if(B[i]>B[j]) then
begin
x:=B[i];
B[i]:=B[j];
B[j]:=x;
end;
writeln('Tabloul initial A: ');
for i:=1 to n do write(A[i]);
writeln;
writeln('Tabloul sortat B: ');
for i:=1 to n do write(B[i]);
writeln;
readln;
end. 