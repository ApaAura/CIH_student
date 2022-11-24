program cn07;

var
  a, b, e, c, x: real;
  n, i: integer;

//5X^3-20X+3=0
function f(x: real): real;
begin f := 5*Power(x,3)-20*x+3; end;

begin
  a := 0; b := 1; n := 20;
  c := a - (f(a)) / (f(b) - f(a)) * (b - a);
  if f(c) * f(a) > 0 then begin e := b; x := a; end
  else begin e := a; x := b; end;
  for i := 1 to n do
  begin
    x := x - (f(x)) / (f(e) - f(x)) * (e - x);
    writeln(x:10:8, ' ', f(x):12:8);
  end;
end.