program cn4;

var
  a, b, c, eps: real;

function f(x: real): real;
begin
  f := Power(x,3)-x-1;
end;

begin
  a := 1; b := 2; eps:=0.0001;
   repeat
    c := (b + a) / 2;
    writeln('x=', c:10:8, ' f(x)=', f(c):12:8);
    if f(c) = 0 then break
    else if f(c) * f(a) > 0 then a := c else b := c;
  until abs(b - a) < eps; 
end.