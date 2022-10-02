Program P101;

var a, b : integer;
procedure P(x : integer; var y : integer);
begin
x:=x+1;
y:=y+1;
writeln('x=', x, ' y=', y);
end; {P }
begin
a:=0;
b:=0;
P(a, b);
writeln('a=', a, ' b=', b);
readln;
end.