Program P11;
var x:real;

function FX(x:real):real;
var functie:real;
begin
functie:=sin(x/2)-sqr(abs(cos(x)-3/4));
FX:=functie;
end;

begin
write('x = '); readln(x);
write('F('+x+')='+FX(x));
end.