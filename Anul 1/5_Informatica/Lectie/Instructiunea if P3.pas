Program P2;
{Elaboarti un program care calculeaza valorile functiei}
var y,x:real;
begin
write('x='); readln(x);
if x<-12 then y:=x*x*x-6*x
else 
if x<-5 then y:=sqrt(sqr(sqr(x))+12)
else 
if x<2 then y:=2*x+12
else if x>=2 then y:=14;
writeln('y=',y)
end.