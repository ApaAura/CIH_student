var n:real;
//S(n)=1+3+5+...+(2*n-1)
function Suma(n:real):real;
begin
if n=0 then Suma:=0
else Suma:=(2*n-1)*Suma(n-1);
end;

//P(n)=1*4*7*...*(3*n-2)
function Produs(n:real):real;
var prod:real;
begin
if n=0 then prod:=0
else prod:=(3*n-2)*Produs(n-1);
Produs:=prod;
end;

begin
write('n = '); readln(n);
writeln('Suma recursiv = '+Suma(n));
writeln('Produs recursiv = '+Produs(n));
end.