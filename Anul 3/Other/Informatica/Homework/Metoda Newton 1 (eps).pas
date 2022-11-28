program cn10;
//ex 5 b pag 34 man cl 12
var
  a, b, xn, xv, M2, m1, e, c: real;

function f(z: real): real;
begin f := Power(z,5)-4*z+9; end;

function fd1(z: real): real;
begin fd1 := 5*Power(z,4)-4; end;

begin
  a := -2; b := 1; M2 := 150; m1 := 1; e := 0.00001;
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