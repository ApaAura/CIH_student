program cn09;

var
  a, b, x, c: real;
  i, n: integer;

function f(z: real): real;
begin f := z * z * z - 2 * z * z + z - 3; end;

function fd1(z: real): real;
begin fd1 := 3 * z * z - 4 * z + 1; end;

begin
  a := 2.1; b := 15; n := 10; i := 0;
  c := a - (f(a)) / (f(b) - f(a)) * (b - a);
  if f(c) * f(a) < 0 then x := a else x := b;
  while i < n do
  begin
    i := i + 1;
    x := x - f(x) / fd1(x);
    writeln('i=', i:2, ' x=', x:15:12, ' f=', f(x):15:12);
  end;
end.