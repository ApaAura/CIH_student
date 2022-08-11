Program P2;
{Suma componentelor variabilei x de tip Vector}
{Numar fix de componente}
const nmax=100;
type Vector=array [1.. nmax] of real;
var x: Vector;
n:1..nmax;
i:integer;
s:real;
begin
write('n='); readln(n);
writeln('Dati ',n,' numere:');
for i:=1 to n do readln(x[i]);
writeln ('Ati introdus: ');
for i:=1 to n do writeln(x[i]);
s:=0;
for i:=1 to n do 
s:=s+x[i];
writeln('Suma='+s);
readln;
end.