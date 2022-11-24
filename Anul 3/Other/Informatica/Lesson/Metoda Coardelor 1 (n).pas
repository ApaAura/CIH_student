program cn07;

var
  a, b, e, c, x: real;
  n, i: integer;

//x^3-0.2x^2+0.2x-2,1=0
function f(x: real): real;
begin f := Power(x,3)-0.2*Power(x,2)+0.2*x-2.1; end;

begin
  a := 1; b := 2; n := 10;
  c := a - (f(a)) / (f(b) - f(a)) * (b - a);
  if f(c) * f(a) > 0 then begin e := b; x := a; end
  else begin e := a; x := b; end;
  for i := 1 to n do
  begin
    x := x - (f(x)) / (f(e) - f(x)) * (e - x);
    writeln(x:10:8, ' ', f(x):12:8);
  end;
end.