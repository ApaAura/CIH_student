Program P2;
{Elaboarti un program care calculeaza valorile functiei}
var c,x,y,z:real;
begin
write('x='); readln(x);
write('y='); readln(y);
write('c='); readln(c);
if c=0 then z:=x*y 
else 
if c<0 then z:=1/(x-y)
else z:=sqrt(x+y);
writeln('z=',z)
end.