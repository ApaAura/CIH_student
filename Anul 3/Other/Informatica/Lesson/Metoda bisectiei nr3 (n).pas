program cn3;

var
  a, b, c: real;
  i, n: integer;

function f(x: real): real;
const
  e = 2.7182818;
begin
  f := power(e, x) - Sqr(x);
end;

begin
  a := -1; b := -0.5; n := 10;
  for i := 1 to n do
  begin
    c := (b + a) / 2;
    writeln('i=', i:3, ' x=', c:10:8, ' f(x)=', f(c):12:8);
    if f(c) = 0 then break
    else if f(c) * f(a) > 0 then a := c else b := c;
  end; 
end.