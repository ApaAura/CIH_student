program cn09;
//ex 4 c pag 34 man cl 12
var
  a, b, x, c: real;
  i, n: integer;

function f(z: real): real;
begin f :=(2*Sqr(x))*cos(x)+2*x*sin(x); end;

function fd1(z: real): real;
begin fd1 :=2*x*sin(x)+2*cos(x); end;

begin
  a := 4; b := 4.5; n := 6; i := 0;
  c := a - (f(a)) / (f(b) - f(a)) * (b - a);
  if f(c) * f(a) < 0 then x := a else x := b;
  while i < n do
  begin
    i := i + 1;
    x := x - f(x) / fd1(x);
    writeln('i=', i:2, ' x=', x:15:12, ' f=', f(x):15:12);
  end;
end.