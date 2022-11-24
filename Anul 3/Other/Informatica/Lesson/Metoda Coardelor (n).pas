program cn07;

var
  a, b, e, c, x: real;
  n, i: integer;

function f(x: real): real;
begin f := ln(x * sin(x)); end;

begin
  a := 0.5; b := 1.5; n := 10;
  {determinarea extremitatii fixe e si a aproximarii initiale x0}
  c := a - (f(a)) / (f(b) - f(a)) * (b - a);
  if f(c) * f(a) > 0 then begin e := b; x := a; end
  else begin e := a; x := b; end;
  {calculul iterativ al solutiei}
  for i := 1 to n do
  begin
    x := x - (f(x)) / (f(e) - f(x)) * (e - x);
    writeln(x:10:8, ' ', f(x):12:8);
  end;
end.