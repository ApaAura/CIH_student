program cn06;

var
  a, b, c, eps: real;

function f(x: real): real;
begin f := 6 * cos(x) + 8 * sin(x); end;

begin
  a := 2; b := 4; eps := 0.00017;
  repeat
    c := (b + a) / 2;
    writeln('x=', c:10:8, ' f(x)=', f(c):12:8);
    if f(c) = 0 then break
    else if f(c) * f(a) > 0 then a := c else b := c;
  until abs(b - a) < eps;
end.