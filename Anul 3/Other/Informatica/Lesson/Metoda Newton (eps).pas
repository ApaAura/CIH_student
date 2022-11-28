program cn10;

var
  a, b, xn, xv, M2, m1, e, c: real;

function f(z: real): real;
begin f := cos(z) * cos(z) - z / 4; end;

function fd1(z: real): real;
begin fd1 := -sin(2 * z) - 1 / 4; end;

begin
  a := 2.4; b := 3; M2 := 2; m1 := 0.03; e := 0.0001;
  c := a - (f(a)) / (f(b) - f(a)) * (b - a);
  if f(c) * f(a) < 0 then begin
    xn := a; xv := b;
  end
  else begin xn := b; xv := a; end;
  while M2 * sqr(xn - xv) / (2 * m1) > e do
  begin
    xv := xn;
    xn := xv - f(xv) / fd1(xv);
    writeln(' x=', xn:15:12, ' f=', f(xn):15:12);
  end;
end.