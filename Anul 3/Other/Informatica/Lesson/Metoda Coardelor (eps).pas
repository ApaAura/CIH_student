program cn08;

var
  Msup, minf, a, b, e, x, xnou, xvechi, eps: real;

function f(x: real): real;
begin
  f := sqr(sqr(x)) - 3 * sqr(x) + 7.5 * x - 1;
end;

begin
  a := -0.5; b := 0.5; eps := 0.0001;
  Msup := 10; minf := 5;
  {determinarea extremitatii fixe si a aproximarii initiale}
  x := a - (f(a)) / (f(b) - f(a)) * (b - a);
  if f(x) * f(a) > 0 then begin e := b; xnou := a; end
  else begin e := a; xnou := b; end;
  {calculul iterativ al solutiei}
  repeat
    xvechi := xnou;
    xnou := xvechi - (f(xvechi)) / (f(e) - f(xvechi)) * (e - xvechi);
    writeln(' x=', xnou:10:8, ' f(x)=', f(xnou):12:8);
  until abs((Msup - minf) / minf * (xnou - xvechi)) < eps;
end.