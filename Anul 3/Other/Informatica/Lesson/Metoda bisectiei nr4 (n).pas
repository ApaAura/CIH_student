program cn4;

var
  a, b, c: real;
  i, n: integer;

function f(x: real): real;
begin
  f := Power(x,3)-x-1;
end;

begin
  a := 1; b := 2; n := 20;
  for i := 1 to n do
  begin
    c := (b + a) / 2;
    writeln('i=', i:3, ' x=', c:10:8, ' f(x)=', f(c):12:8);
    if f(c) = 0 then break
    else if f(c) * f(a) > 0 then a := c else b := c;
  end; 
end.